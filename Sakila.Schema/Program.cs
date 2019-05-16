using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using global::Schema.MySql;
using Schema.Infrastructure;

namespace Sakila.Schema
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "server= localhost;port=13306;database=sakila;uid=sakilauser;pwd=sakilauser";
            TypeHelper.TypeMapping["timestamp"] = typeof(DateTime);
            TypeHelper.TypeMapping["tinyint"] = typeof(sbyte);
            TypeHelper.DbTypeMapping["timestamp"] = DbType.DateTime;
            var schemaManager = new MySqlSchemaManager(connectionString);
            var tables = schemaManager.GetTables();
            foreach(var table in tables)
            {
                Console.WriteLine($"{table.TableSchema} {table.TableName}");

                foreach(var column in table.Columns)
                {
                    column.IsUnsigned = "NO";
                    Console.WriteLine($"\t{column.ColumnName} {column.DataType}  {column.ObjectTypeName}");

                }
            }
            Console.ReadLine();
        }
    }
}
