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
using Schema.Queries;

namespace Schema
{
    public class SchemaManager : IDisposable
    {
        protected bool isInternalConnection;
        protected readonly DbConnection connection;

        protected virtual ColumnListQuery columnQuery => new ColumnListQuery(connection);
        protected virtual TableConstraintListQuery constraintQuery => new TableConstraintListQuery(connection);
        protected virtual ConstraintColumnListQuery constraintColumnQuery => new ConstraintColumnListQuery(connection);
        protected virtual ReferentialConstraintQuery referentialConstraintQuery => new ReferentialConstraintQuery(connection);
        protected virtual IndexListQuery indexQuery => new IndexListQuery(connection);
        protected virtual IndexColumnListQuery indexColumnQuery => new IndexColumnListQuery(connection);
        protected virtual RoutineListQuery routineListQuery => new RoutineListQuery(connection);
        protected virtual ParameterListQuery parameterListQuery => new ParameterListQuery(connection);
        protected virtual SequenceListQuery sequenceListQuery => new SequenceListQuery(connection);
        protected virtual ReferentialConstraintListQuery referentialConstraintListQuery => new ReferentialConstraintListQuery(connection);

        public SchemaManager()
        {

        }
        public SchemaManager(DbConnection connection)
        {
            this.connection = connection;
            this.isInternalConnection = false;
        }

        public SchemaManager(string connectionString)
        {
            this.connection = CreateConnection(connectionString);
            this.connection.Open();
            this.isInternalConnection = true;
        }
        public SchemaManager(string connectionString, string providerName)
        {
            this.connection = CreateConnection(connectionString, providerName);
            this.connection.Open();
            this.isInternalConnection = true;
        }
        DbConnection CreateConnection(string connectionString, string providerName = "System.Data.SqlClient")
        {
            var factory = DbProviderFactories.GetFactory(providerName);
            var connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;

            return connection;

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
            }
            return tables;
        }

        private void BuildTable(Table table)
        {
            // 列が構成されていたらそのテーブルは構成済みとみなす
            if (table.Columns != null)
            {
                return;
            }
            table.Columns = columnQuery.Execute(table.TableSchema, table.TableName).ToList();
            table.Constraints = constraintQuery.Execute(table.TableSchema, table.TableName).ToList();

            table.ReferentialConstraints = new List<ReferentialConstraint>();
            foreach (var constraint in table.Constraints)
            {
                constraint.ConstraintColumns = constraintColumnQuery.Execute(constraint.ConstraintSchema, constraint.ConstraintName, table.TableSchema, table.TableName).ToList();
            }

            // mysql does not have "sys.indexes"
            table.Indexes = indexQuery.Execute(table.TableSchema, table.TableName).ToList();
            var indexColumns = indexColumnQuery.Execute(table.TableSchema, table.TableName);
            foreach (var index in table.Indexes)
            {
                index.Columns = indexColumns.Where(x => x.IndexId == index.IndexId).ToList();
            }
        }
        public List<Association> GetAssociations()
        {
            var keyColumnUsageQuery = new KeyColumnUsageQuery(connection);
            var list = new List<Association>();

            var query = referentialConstraintListQuery.Execute()
                .GroupBy(x => new {
                    x.BaseTableSchema,
                    x.BaseTableName
                });
            foreach(var group in query)
            {
                var baseTableConstraintColumns = keyColumnUsageQuery.Execute(group.Key.BaseTableSchema, group.Key.BaseTableName).ToList();
                foreach(var constraint in group)
                {

                    var fkeyColumns = baseTableConstraintColumns.Where(x => x.ConstraintSchema == constraint.ConstraintSchema && x.ConstraintName == constraint.ConstraintName);
                    var referencedKeyColumns = constraintColumnQuery.Execute(constraint.UniqueConstraintSchema, constraint.UniqueConstraintName, constraint.ReferenceTableSchema, constraint.ReferenceTableName);

                    var baseTableKey = baseTableConstraintColumns.Where(x => x.ConstraintType == "PRIMARY KEY");

                    var association = new Association(constraint, fkeyColumns, referencedKeyColumns, baseTableKey);
                    list.Add(association);
                }
            }

            return list;
        }
        public List<Routine> GetRoutines()
        {
            var routines = routineListQuery.Execute().ToList();
            foreach(var routine in routines)
            {
                routine.Parameters = parameterListQuery.Execute(routine.SpecificSchema, routine.SpecificName).ToList();

            }
            return routines;
        }
        public List<Sequence> GetSequences()
        {
            var sequences = sequenceListQuery.Execute().ToList();
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
