﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Schema;
namespace Schema.Infrastructure
{
    public class SchemaWriter : IDisposable
    {
        private readonly SchemaManager manager;
        private readonly StreamWriter writer;

        public SchemaWriter(SchemaManager manager,string filename)
        {
            this.manager = manager;
            this.writer = new System.IO.StreamWriter(filename);
        }
        public void Write()
        {
            Write($"{{");
            PushIndent();

            WriteTables(manager.GetTables());
            WriteRoutines(manager.GetRoutines());
            WriteSequences(manager.GetSequences());

            PopIndent();
            Write($"}}");
        }

        public void WriteRoutines(List<Routine> routines)
        {
            Write($"\"routines\": [");
            PushIndent();
            var count = 0;
            foreach (var routine in routines)
            {
                Write($@"{{");
                PushIndent();
                Write($@"""routine_schema"": ""{routine.SpecificSchema}"",");
                Write($@"""routine_name"": ""{routine.SpecificName}"",");
                Write($@"""data_type"": ""{routine.DataType}"",");
                Write($@"""object_name"": ""{routine.ObjectName}"",");
                Write($@"""parameters"": [");

                PushIndent();
                var parameterCount = 0;
                foreach (var parameter in routine.Parameters)
                {
                    Write($@"{{");
                    PushIndent();
                    Write($@"""parameter_name"": ""{parameter.ParameterName}"",");
                    Write($@"""data_type"": ""{parameter.DataType}"",");
                    Write($@"""mode"": ""{parameter.ParameterMode}"",");
                    Write($@"""object_name"": ""{parameter.ObjectName}""");
                    PopIndent();
                    Write($@"}}" + (parameterCount++ < routine.Parameters.Count - 1 ? "," : ""));
                }
                PopIndent();
                Write($@"]");

                PopIndent();
                Write($@"}}" + (count++ < routines.Count - 1 ? "," : ""));
            }
            PopIndent();
            Write($"],");
        }
        public void WriteSequences(List<Sequence> sequences)
        {
            Write($"\"sequences\": [");
            PushIndent();
            var count = 0;
            foreach (var sequence in sequences)
            {
                Write($@"{{");
                PushIndent();
                Write($@"""sequence_schema"": ""{sequence.SequenceSchema}"",");
                Write($@"""sequence_name"": ""{sequence.SequenceName}"",");
                Write($@"""data_type"": ""{sequence.DataType}"",");
                Write($@"""object_name"": ""{sequence.ObjectName}""");

                PopIndent();
                Write($@"}}" + (count++ < sequences.Count - 1 ? "," : ""));
            }
            PopIndent();
            Write($"]");

        }
        public void WriteTables(List<Table> tables)
        {

            Write($"\"tables\": [");
            PushIndent();
            var tableCount = 0;
            foreach (var table in tables)
            {
                Write($@"{{");
                PushIndent();
                Write($@"""table_schema"": ""{table.TableSchema}"",");
                Write($@"""table_name"": ""{table.TableName}"",");
                WriteColumns(table);

                WritePrimaryKey(table);

                WriteIndexes(table);

                WriteForeignKeys(tables, table);

                PopIndent();
                Write($@"}}" + ((tableCount++ < (tables.Count - 1)) ? ",": ""));
            }
            PopIndent();
            Write($"],");

        }

        private void WriteForeignKeys(List<Schema.Table> tables, Schema.Table table)
        {
            Write($@"""foreign_keys"": [");
            PushIndent();
            var keyCount = 0;
            var foreignKeyCount = table.Constraints.Where(x => x.ConstraintType == "FOREIGN KEY").Count();
            foreach (var key in table.ForeignKeys)
            {
                var referentialConstraint = table.ReferentialConstraints.FirstOrDefault(x => x.ConstraintSchema == key.ConstraintSchema && x.ConstraintName == key.ConstraintName);
                Write($@"{{");
                PushIndent();

                Write($@"""constraint_name"": ""{key.ConstraintName}"",");
                Write($@"""columns"": [");
                PushIndent();
                var columnCount = 0;
                foreach (var column in key.Columns)
                {
                    Write($@"""{column}""" + (columnCount++ < (key.Columns.Count - 1) ? "," : ""));
                }
                PopIndent();
                Write($@"],");

                Write($@"""references"": {{");
                PushIndent();

                Write($@"""table"": ""{key.ReferencedTableName}"",");
                Write($@"""columns"": [");
                PushIndent();
                var referencedColumnCount = 0;
                foreach (var keyColumn in key.ReferenceColumns)
                {
                    Write($@"""{keyColumn}""" + (referencedColumnCount++ < (key.ReferenceColumns.Count - 1) ? "," : ""));

                }
                PopIndent();
                Write($@"]");

                PopIndent();
                Write($@"}}");

                PopIndent();
                Write($@"}}" + (keyCount++ < (foreignKeyCount - 1) ? "," : ""));
            }
            PopIndent();
            Write($@"]");
        }

        private void WriteIndexes(Schema.Table table)
        {
            Write($@"""indexes"": [");
            PushIndent();
            int indexcount = 0;
            foreach (var index in table.Indexes)
            {
                Write($@"{{");
                PushIndent();
                Write($@"""index_name"": ""{index.Name}"",");
                Write($@"""index_columns"": [");
                PushIndent();

                int count = 0;
                foreach (var column in index.Columns)
                {
                    Write($@"""{column.ColumnName}""" + (count++ < (index.Columns.Count - 1) ? "," : ""));
                }
                
                PopIndent();
                Write($@"]");
                PopIndent();
                Write($@"}}" + (indexcount++ < (table.Indexes.Count - 1) ? "," : ""));

            }
            PopIndent();
            Write($@"],");
        }

        private void WritePrimaryKey(Schema.Table table)
        {
            Write($@"""primary_key"": [");
            PushIndent();
            var keyColumnCount = 0;
            foreach (var keyColumn in table.PrimaryKeyColumns)
            {
                Write($@"""{keyColumn}"""  + (keyColumnCount++ < (table.PrimaryKeyColumns.Count() - 1) ? ", " : ""));

            }
            PopIndent();
            Write($@"],");
        }

        private void WriteColumns(Schema.Table table)
        {
            Write($@"""columns"": [");
            PushIndent();
            var columnCount = 0;
            foreach (var column in table.Columns)
            {
                Write($@"{{");
                PushIndent();
                Write($@"""column_name"": ""{column.ColumnName}"",");
                Write($@"""data_type"": ""{column.DataType}"",");
                Write($@"""length"": ""{column.Length}"",");
                Write($@"""precision"": ""{column.Precision}"",");
                Write($@"""scale"": ""{column.Scale}"",");

                Write($@"""nullable"": ""{column.IsNullable}"",");
                Write($@"""default_value"": {column.DefaultValueLiteral},");
                Write($@"""object_name"": ""{column.ObjectName}"",");
                Write($@"""object_type"": ""{column.ObjectTypeName}""");

                PopIndent();
                Write($@"}}" + (columnCount++ < (table.Columns.Count - 1) ? ", " : ""));

            }
            PopIndent();
            Write($@"],");
        }

        public void Dispose()
        {
            writer.Dispose();
        }

        private int indent = 0;
        private void PushIndent()
        {
            indent++;
        }
        private void PopIndent()
        {
            indent--;
        }
        private void Write(string s)
        {
            writer.Write(new string(' ', indent * 4));
            writer.WriteLine(s);
        }
    }
}
