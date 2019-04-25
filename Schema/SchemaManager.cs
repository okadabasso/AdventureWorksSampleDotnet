using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;
using Schema.Infrastructure;

namespace Schema
{
    public class SchemaManager : IDisposable
    {
        private bool isInternalConnection;
        private readonly DbConnection connection;
        public SchemaManager(DbConnection connection)
        {
            this.connection = connection;
            this.isInternalConnection = false;
        }

        public SchemaManager(string connectionString)
        {
            var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
            this.connection = factory.CreateConnection();
            this.connection.ConnectionString = connectionString;
            this.connection.Open();
            this.isInternalConnection = true;
        }
        public SchemaManager(string connectionString, string providerName)
        {
            var factory = DbProviderFactories.GetFactory(providerName);
            this.connection = factory.CreateConnection();
            this.connection.ConnectionString = connectionString;
            this.connection.Open();
            this.isInternalConnection = true;
        }
        public void Dispose()
        {
            if(isInternalConnection && connection != null)
            {
                connection.Close();
                connection.Dispose();

            }
        }



        public List<Table> GetTables()
        {
            var tableQuery = new Queries.TableListQuery(connection);

            var tables = tableQuery.Execute().ToList();
            foreach(var table in tables)
            {
                BuildTable(table);
                BuildReferences(tables, table);
            }
            return tables;
        }
        private void BuildReferences(List<Table> tables, Table baseTable)
        {
            baseTable.ForeignKeys = new List<ForeignKey>();
            foreach (var constraint in baseTable.Constraints.Where(x => x.ConstraintType == "FOREIGN KEY"))
            {
                var foreignKey = CreateForeignKey(tables, baseTable, constraint);
                if(foreignKey != null)
                {
                    baseTable.ForeignKeys.Add(foreignKey);
                }
            }
        }
        private ForeignKey CreateForeignKey(List<Table> tables, Table baseTable, TableConstraint constraint)
        {
            var referentialConstraint = baseTable.ReferentialConstraints
                .FirstOrDefault(x =>
                    x.ConstraintSchema == constraint.ConstraintSchema &&
                    x.ConstraintName == constraint.ConstraintName);
            if (referentialConstraint == null)
            {
                return null;
            }

            var referencedTable = tables.FirstOrDefault(x => 
                x.TableSchema == referentialConstraint.ReferenceTableSchema && 
                x.TableName == referentialConstraint.ReferenceTableName);
            if (referencedTable == null)
            {
                return null;
            }
            BuildTable(referencedTable);
            var foreignKey = new ForeignKey() {
                ConstraintSchema = constraint.ConstraintSchema,
                ConstraintName = constraint.ConstraintName,
                BaseTableSchema = baseTable.TableSchema,
                BaseTableName = baseTable.TableName,
                ReferencedTableSchema = referencedTable.TableSchema,
                ReferencedTableName = referencedTable.TableName,
                Columns = constraint.ConstraintColumns
                    ?.OrderBy(x => x.OrdinalPosition).Select(x => x.ColumnName).ToList() 
                    ?? new List<string>(),
                ReferenceColumns = referencedTable.Constraints // reference may be unique index 
                    .FirstOrDefault(x => x.ConstraintType == "PRIMARY KEY")
                        ?.ConstraintColumns
                            ?.OrderBy(x => x.OrdinalPosition).Select(x => x.ColumnName).ToList()
                        ?? baseTable.Indexes.FirstOrDefault(x => x.Name == constraint.ConstraintName)
                            ?.Columns.OrderBy(x => x.IndexColumnId).Select(x => x.ColumnName).ToList()
                        ?? new List<string>()
            };
            return foreignKey;
        }
        private void BuildTable(Table table)
        {
            // 列が構成されていたらそのテーブルは構成済みとみなす
            if (table.Columns != null)
            {
                return;
            }
            var columnQuery = new Queries.ColumnListQuery(connection);
            var constraintQuery = new Queries.TableConstraintListQuery(connection);
            var constraintColumnQuery = new Queries.ConstraintColumnListQuery(connection);
            var referentialConstraintQuery = new Queries.ReferentialConstraintQuery(connection);
            var indexQuery = new Queries.IndexListQuery(connection);
            var indexColumnQuery = new Queries.IndexColumnListQuery(connection);

            table.Columns = columnQuery.Execute(table.TableSchema, table.TableName).ToList();

            table.Constraints = constraintQuery.Execute(table.TableSchema, table.TableName).ToList();

            table.ReferentialConstraints = new List<ReferentialConstraint>();
            foreach (var constraint in table.Constraints.Where(x => x.ConstraintType == "PRIMARY KEY" || x.ConstraintType == "FOREIGN KEY"))
            {
                constraint.ConstraintColumns = constraintColumnQuery.Execute(constraint.ConstraintSchema, constraint.ConstraintName).ToList();
                if (constraint.ConstraintType == "FOREIGN KEY")
                {
                    var referentialConstraint = referentialConstraintQuery.Execute(constraint.ConstraintSchema, constraint.ConstraintName).First();
                    table.ReferentialConstraints.Add(referentialConstraint);
                }
            }

            table.Indexes = indexQuery.Execute(table.TableSchema, table.TableName).ToList();
            var indexColumns = indexColumnQuery.Execute(table.TableSchema, table.TableName);
            foreach (var index in table.Indexes)
            {
                index.Columns = indexColumns.Where(x => x.IndexId == index.IndexId).ToList();
            }
        }
        public List<Routine> GetRoutines()
        {
            var query = new Queries.RoutineListQuery(connection);
            var routines = query.Execute().ToList();
            foreach(var routine in routines)
            {
                var parameterQuery = new Queries.ParameterListQuery(connection);
                routine.Parameters = parameterQuery.Execute(routine.SpecificSchema, routine.SpecificName).ToList();

            }
            return routines;
        }
        public List<Sequence> GetSequences()
        {
            var query = new Queries.SequenceListQuery(connection);
            var sequences = query.Execute().ToList();
            return sequences;
        }

        public void WriteJson(string filename)
        {
            using (var writer = new SchemaWriter(this, filename))
            {
                writer.Write();
            }
        }
    }
}
