using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

using Schema;
using Schema.Infrastructure;
using AdventureWorksSample1.Models;
namespace AdventureWorksSample1
{
    public class SchemaClassGenerator
    {
        private static void CreateInformationSchemaEntities()
        {
            CreateObjectClass("TABLES");
            CreateObjectClass("COLUMNS");
            CreateObjectClass("KEY_COLUMN_USAGE");
            CreateObjectClass("TABLE_CONSTRAINTS");
            CreateObjectClass("REFERENTIAL_CONSTRAINTS");

            CreateObjectClass("ROUTINES");
            CreateObjectClass("PARAMETERS");
            CreateObjectClass("ROUTINE_COLUMNS");
            CreateObjectClass("SEQUENCES");

            CreateIndexObjectEntity();
            CreateIndexColumnObjectEntity();
            //Sample();
        }

        private static void CreateObjectClass(string objectName)
        {
            var inflector = new Inflector();
            var className = inflector.Singularize(inflector.Pascalize(objectName));

            using (var db = new AdventureWorks())
            {
                db.Database.Connection.Open();
                var command = new SqlCommand($"select * from INFORMATION_SCHEMA.{objectName} where 1 = 0", db.Database.Connection as SqlConnection);
                using (var reader = command.ExecuteReader())
                {
                    BuildObjectClass(objectName, reader);

                }
            }
        }

        public static void CreateIndexObjectEntity()
        {

            using (var db = new AdventureWorks())
            {
                db.Database.Connection.Open();
                var command = new SqlCommand($@"select * from  sys.indexes ", db.Database.Connection as SqlConnection);

                using (var reader = command.ExecuteReader())
                {
                    BuildObjectClass("INDEX", reader);
                }
            }

        }
        public static void CreateIndexColumnObjectEntity()
        {

            using (var db = new AdventureWorks())
            {
                db.Database.Connection.Open();
                var command = new SqlCommand($@"select
	SCHEMA_NAME(objects.schema_id) as TABLE_SCHEMA,
	objects.name as TABLE_NAME,
	indexes.name as INDEX_NAME,
	indexes.type_desc as TYPE_DESC,
	indexes.index_id as INDEX_ID,
	index_columns.index_column_id as INDEX_COLUMN_ID,
	columns.name as COLUMN_NAME,
	indexes.is_primary_key as IS_PRIMARY_KEY
from 
	sys.objects
	inner join sys.indexes
		on objects.object_id = indexes.object_id
	inner join sys.index_columns
		on objects.object_id = index_columns.object_id
		and indexes.index_id = index_columns.index_id
	inner join sys.columns
		on index_columns.object_id = columns.object_id
		and index_columns.column_id = columns.column_id
where
	1 = 0
order by
	index_columns.index_id,
	index_columns.index_column_id
 ", db.Database.Connection as SqlConnection);
                using (var reader = command.ExecuteReader())
                {
                    BuildObjectClass("INDEX_COLUMN", reader);
                }
            }

        }
        private static void BuildObjectClass(string objectName, IDataReader reader)
        {
            var inflector = new Inflector();
            var className = inflector.Singularize(inflector.Pascalize(objectName));
            using (var writer = new StreamWriter(className + ".cs"))
            {
                writer.WriteLine(@"using System;");
                writer.WriteLine(@"using System.ComponentModel.DataAnnotations;");
                writer.WriteLine(@"using System.ComponentModel.DataAnnotations.Schema;");
                writer.WriteLine(@"namespace Schema");
                writer.WriteLine(@"{");
                writer.WriteLine($@"    [Table(""{objectName}"")]");
                writer.WriteLine($@"    public class {className}");
                writer.WriteLine(@"    {");

                var schemaTable = reader.GetSchemaTable();

                if (schemaTable == null)
                {
                    return;
                }

                var cols = schemaTable.Columns;

                foreach (DataRow row in schemaTable.Rows)
                {
                    var columnName = row["ColumnName"].ToString();
                    var propertyName = inflector.Pascalize(columnName);
                    var allowNull = (bool)row["AllowDbNull"];
                    var dataType = TypeHelper.TypeAlias[row["DataType"].ToString()];

                    if (allowNull && dataType != "object" && dataType != "string")
                    {
                        dataType += "?";
                    }

                    writer.WriteLine($@"        [Column(""{columnName}"")]");
                    writer.WriteLine($"        public {dataType} {propertyName} {{ get; set; }}");
                    writer.WriteLine(@"");
                }

                writer.WriteLine(@"    }");
                writer.WriteLine(@"}");

            }
        }
    }
}
