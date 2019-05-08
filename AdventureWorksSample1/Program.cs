using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using AdventureWorksSample1.Models;
using AdventureWorksSample1.Models4;
using Schema;

namespace AdventureWorksSample1
{
    internal class Program
    {
        private static readonly Dictionary<string, string> TypeAlias = new Dictionary<string, string>
        {
            {"System.Object", "object"},
            {"System.String", "string"},
            {"System.Boolean", "bool"},
            {"System.Byte", "byte"},
            {"System.SByte", "sbyte"},
            {"System.Int16", "short"},
            {"System.UInt16", "ushort"},
            {"System.Int32", "int"},
            {"System.UInt32", "uint"},
            {"System.Int64", "long"},
            {"System.UInt64", "ulong"},
            {"System.Single", "float"},
            {"System.Double", "double"},
            {"System.Decimal", "decimal"},
            {"System.Char", "char"},
            {"System.DateTime", "DateTime"}
        };

        private static void Main(string[] args)
        {
            var t = typeof(int);


            SampleDbFunctionExecute();
            //FindAssociation();
            Console.ReadLine();
        }
        static void SampleDbFunctionExecute()
        {
            using (var context = new Sample.Entities.SampleDbContext())
            {
                var procedure = new Sample.Entities.UfnGetDocumentStatusText();
                var result = procedure.Execute(2);
                Console.WriteLine("result = {0}", result);
            }
        }
        static void SampleDbProcedureExecute()
        {
            using (var context = new Sample.Entities.SampleDbContext())
            {
                var procedure = new Sample.Entities.UspGetEmployeeManagers();
                var query = procedure.Execute(290);

            }
        }
        static void SampleDbProcedureQuery()
        {
            using (var context = new Sample.Entities.SampleDbContext())
            {
                var procedure = new Sample.Entities.UspGetEmployeeManagers();
                var query = procedure.Query<EmployeeManager>(290);
                foreach(var item in query)
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName} {item.ManagerFirstName} {item.ManagerLastName}");
                }
            }
        }
        static void SampleQuery(string name)
        {
            using(var context = new Sample.Entities.SampleDbContext())
            {
                var query = context.Product.Include(x => x.BillOfMaterials).Where(x => x.Name.StartsWith(name)).OrderBy(x => x.ProductId);
                foreach(var product in query)
                {
                    Console.WriteLine($"{product.ProductId} {product.Name} {product.SellEndDate} {product.ModifiedDate}");
                    foreach(var n in product.BillOfMaterials)
                    {
                        Console.WriteLine($"\t{n.ComponentId} {n.BillOfMaterialsId} {n.UnitMeasureCode}");

                    }
                }

            }
        }
        private static void WriteJson()
        {
            using(var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString))
            {
                using (var schemaManager = new SchemaManager(connection))
                {
                    schemaManager.WriteJson("database.json");
                }

            }
        }
        private static void FindAssociation()
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString))
            {
                using (var schemaManager = new SchemaManager(connection))
                {
                    var tables = schemaManager.GetTables();
                    foreach(var table in tables)
                    {
                        Console.WriteLine(table.ObjectName);

                        // このテーブルを参照する
                        var dependents = tables.Where(x => x.ForeignKeys.Any(y => y.ReferencedTable.NameEquals(table)))
                            .SelectMany(x => x.ForeignKeys.Where(r => r.ReferencedTable.NameEquals(table)))
                            .GroupBy(x => new { x.BaseTable.TableSchema, x.BaseTable.TableName });

                        foreach (var group in dependents)
                        {
                            var n = 0;
                            foreach(var fkey in group)
                            {
                                // one or many
                                var multiplicityA = (fkey.PrincipalRole.Required ? "1.." : "0..") + fkey.PrincipalRole.Multiplicity;
                                var multiplicityB = (fkey.DependentRole.Required ? "1.." : "0..") + fkey.DependentRole.Multiplicity;
                                Console.Write($"{table.ObjectName}\t ({multiplicityA}) <---- ({multiplicityB})");
                                Console.Write($" {fkey.BaseTable.TableName} as {fkey.DependentRole.RoleName}{n:#}");
                                Console.WriteLine($" by {string.Join(",", fkey.Columns)}");
                                n++;
                            }
                        }

                        // このテーブルが参照する
                        foreach (var group in table.ForeignKeys.GroupBy(x => new { x.ReferencedTable.TableSchema, x.ReferencedTable.TableName}))
                        {
                            var n = 0;
                            foreach (var fkey in group)
                            {
                                var multiplicityA = (fkey.PrincipalRole.Required ? "1.." : "0..") + fkey.PrincipalRole.Multiplicity;
                                var multiplicityB = (fkey.DependentRole.Required ? "1.." : "0..") + fkey.DependentRole.Multiplicity;

                                Console.Write($"{table.ObjectName}\t ({multiplicityB}) ----> ({multiplicityA})");
                                Console.Write($" {fkey.ReferencedTable.TableName} as {fkey.PrincipalRole.RoleName}{n:#}");
                                Console.WriteLine($" by {string.Join(",", fkey.Columns)}");

                                n++;
                            }
                        }

                    }
                }

            }
        }
        private static void EntityReference4()
        {
            using (var context = new Model1())
            {
                var a = new {
                    a = 1,
                    b = 2
                };
                var query = context.table1
                    .Where(x => x.id == 5 && x.name == "entity1")
                    .Select(x => new {
                        x.id,
                        x.name
                    });

                foreach (var item in query)
                {
                    Console.WriteLine($"{item.id} {item.name}");
                }
            }
        }

        private static void EntityReference3()
        {
            using (var context = new Model1())
            {
                var t5b = new table5b { key1 = 1, name = "new" };
                var t5 = context.table5.Find(1, 3);
                var t7 = new table6 { name = "a6", refTable = t5 };
                context.table6.Add(t7);
                context.SaveChanges();
            }
        }

        private static void EntityReference2()
        {
            using (var context = new Model1())
            {
                context.Database.Log = s => Console.WriteLine(s);

                foreach (var table1 in context.table1.Include(x => x.table2))
                {
                    Console.WriteLine("{0} {1}", table1.id, table1.name);

                    foreach (var table2 in table1.table2)
                        Console.WriteLine("\t{0} {1}", table2.id, table2.name);

                }
            }
        }

        private static void EntityReference()
        {
            using (var context = new Model1())
            {
                var entity1 = new table1 { name = "entity 1" };
                var entity2 = new table1 { name = "entity 2" };
                context.table1.Add(entity1);
                context.table1.Add(entity2);
                var table2entity1 = new table2 { name = "t2 e1", table1 = entity1 };
                context.table2.Add(table2entity1);
                context.SaveChanges();
            }
        }

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

        private static void Sample()
        {
            using (var db = new AdventureWorks())
            {
                db.Database.Connection.Open();
                var command = new
                SqlCommand("select * from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='Employee'",
                    db.Database.Connection as SqlConnection);

                using (var reader = command.ExecuteReader())
                {
                    var schemaTable = reader.GetSchemaTable();
                    var cols = schemaTable.Columns;

                    foreach (DataRow row in schemaTable.Rows)
                    {
                        foreach (DataColumn col in cols)
                        {
                            Console.WriteLine(col.ColumnName + " " + row[col.ColumnName]);
                        }

                        Console.WriteLine();
                    }
                }
            }
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
            using(var writer = new StreamWriter(className + ".cs"))
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
                    var dataType = TypeAlias[row["DataType"].ToString()];

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

    public class Inflector
    {
        private Dictionary<string, string> PluralIllegular;
        private Dictionary<string, string> PluralRules;
        private Dictionary<string, string>
        SingularIllegular;
        private Dictionary<string, string> SingularRules;
        private List<string> Uninflected;

        private void InitializeUninflected()
        {
            Uninflected = new List<string>
            {
                "deer",
                "fish",
                "measles",
                "ois",
                "pox",
                "rice",
                "sheep",
                "Amoyese",
                "bison",
                "bream",
                "buffalo",
                "cantus",
                "carp",
                "cod",
                "coitus",
                "corps",
                "diabetes",
                "elk",
                "equipment",
                "flounder",
                "gallows",
                "Genevese",
                "Gilbertese",
                "headquarters",
                "herpes",
                "information",
                "innings",
                "Lucchese",
                "mackerel",
                "mews",
                "moose",
                "mumps",
                "news",
                "nexus",
                "Niasese",
                "Pekingese",
                "Portuguese",
                "proceedings",
                "rabies",
                "salmon",
                "scissors",
                "series",
                "shears",
                "siemens",
                "species",
                "trousers",
                "trout",
                "tuna",
                "whiting",
                "wildebeest",
                "Yengeese"
            };
        }

        private void InitializePluralRules()
        {
            PluralRules = new Dictionary<string, string>();
            PluralRules.Add("(s)tatus$", "$1tatuses");
            PluralRules.Add("^(ox)$", "$1en");
            PluralRules.Add("([m|l])ouse$", "$1ice");
            PluralRules.Add("(matr|vert|ind)ix|ex$", "$1ices");
            PluralRules.Add("(x|ch|ss|sh)$", "$1es");
            PluralRules.Add("(r|t|c)y$", "$1ies");
            PluralRules.Add("(hive)$", "$1s");
            PluralRules.Add("([^f])fe$", "$1ves");
            PluralRules.Add("([lr])f$", "$1ves");
            PluralRules.Add("(.*)sis$", "$1ses");
            PluralRules.Add("([ti])um$", "$1a");
            PluralRules.Add("(buffal|tomat)o$", "$1oes");
            PluralRules.Add("(bu)s$", "$1ses");
            PluralRules.Add("(alias)", "$1es");
            PluralRules.Add("(octop|vir)us$", "$1i");
            PluralRules.Add("(.*)s$", "$1s");
            PluralRules.Add("^(.*)$", "$1s");
            PluralIllegular = new Dictionary<string, string>();
            PluralIllegular.Add("atlas", "atlases");
            PluralIllegular.Add("child", "children");
            PluralIllegular.Add("corpus", "corpuses");
            PluralIllegular.Add("ganglion", "ganglions");
            PluralIllegular.Add("genus", "genera");
            PluralIllegular.Add("graffito", "graffiti");
            PluralIllegular.Add("leaf", "leaves");
            PluralIllegular.Add("man", "men");
            PluralIllegular.Add("money", "monies");
            PluralIllegular.Add("mythos", "mythoi");
            PluralIllegular.Add("numen", "numina");
            PluralIllegular.Add("opus", "opuses");
            PluralIllegular.Add("penis", "penises");
            PluralIllegular.Add("person", "people");
            PluralIllegular.Add("sex", "sexes");
            PluralIllegular.Add("soliloquy", "soliloquies");
            PluralIllegular.Add("testis", "testes");
            PluralIllegular.Add("woman", "women");
            PluralIllegular.Add("move", "moves");
            PluralIllegular.Add("datum", "data");
            PluralIllegular.Add("criterion", "criteria");
        }

        private void InitializeSingularRules()
        {
            SingularRules = new Dictionary<string, string>();
            SingularRules.Add("(s)tatuses$", "$1tatus");
            SingularRules.Add("^(ox)en$", "$1");
            SingularRules.Add("([m|l])ice$", "$1ouse");
            SingularRules.Add("(matr)ices$", "$1ix");
            SingularRules.Add("(vert|ind)ices$", "$1ex");
            SingularRules.Add("(cris|ax|test)es$", "$1is");
            SingularRules.Add("(x|ch|ss|sh)es$", "$1");
            SingularRules.Add("(r|t|c)ies$", "$1y");
            SingularRules.Add("(movie)s$", "$1");
            SingularRules.Add("(hive)s$", "$1");
            SingularRules.Add("([^f])ves$", "$1fe");
            SingularRules.Add("([lr])ves$", "$1f");
            SingularRules.Add("(analy|ba|diagno|parenthe|synop|the)ses$", "$1sis");
            SingularRules.Add("([ti])a$", "$1um");
            SingularRules.Add("(buffal|tomat)oes$", "$1o");
            SingularRules.Add("(bu)ses$", "$1s");
            SingularRules.Add("(alias)es", "$1");
            SingularRules.Add("(octop|vir)i$", "$1us");
            SingularRules.Add("(.*)s$", "$1");
            SingularRules.Add("(.*)", "$1");
            SingularIllegular = new Dictionary<string, string>();
            SingularIllegular.Add("atlases", "atlas");
            SingularIllegular.Add("children", "child");
            SingularIllegular.Add("corpuses", "corpus");
            SingularIllegular.Add("ganglions", "ganglion");
            SingularIllegular.Add("genera", "genus");
            SingularIllegular.Add("graffiti", "graffito");
            SingularIllegular.Add("leaves", "leaf");
            SingularIllegular.Add("men", "man");
            SingularIllegular.Add("monies", "money");
            SingularIllegular.Add("mythoi", "mythos");
            SingularIllegular.Add("numina", "numen");
            SingularIllegular.Add("opuses", "opus");
            SingularIllegular.Add("penises", "penis");
            SingularIllegular.Add("people", "person");
            SingularIllegular.Add("sexes", "sex");
            SingularIllegular.Add("soliloquies", "soliloquy");
            SingularIllegular.Add("testes", "testis");
            SingularIllegular.Add("women", "woman");
            SingularIllegular.Add("moves", "move");
            SingularIllegular.Add("data", "datum");
            SingularIllegular.Add("criteria", "criterion");
        }


        public string Pluralize(string word)
        {
            if (Uninflected == null)
            {
                InitializeUninflected();
            }

            if (PluralRules == null)
            {
                InitializePluralRules();
            }

            if (Uninflected.Any(x => x.ToLower() ==
                    word.ToLower()))
            { return word; }

            foreach (var keyValue in PluralIllegular)
                if (Regex.IsMatch(word, keyValue.Key, RegexOptions.IgnoreCase))
                {
                    return Regex.Replace(word, keyValue.Key, keyValue.Value);
                }

            foreach (var keyValue in PluralRules)
            {
                if (Regex.IsMatch(word, keyValue.Key, RegexOptions.IgnoreCase))
                {
                    var replaced = Regex.Replace(word, keyValue.Key, keyValue.Value);
                    return replaced;
                }
            }

            return word;
        }

        public string Singularize(string word)
        {
            if (Uninflected == null)
            {
                InitializeUninflected();
            }

            if (SingularRules == null)
            {
                InitializeSingularRules();
            }

            if (Uninflected.Any(x => x == word.ToLower()))
            {
                return word;
            }

            foreach (var keyValue in SingularIllegular)
                if (Regex.IsMatch(word, keyValue.Key, RegexOptions.IgnoreCase))
                    return Regex.Replace(word, keyValue.Key, keyValue.Value);

            foreach (var keyValue in SingularRules)
                if (Regex.IsMatch(word, keyValue.Key, RegexOptions.IgnoreCase))
                    return Regex.Replace(word, keyValue.Key, keyValue.Value);

            return word;
        }

        public string Pascalize(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return word;
            }

            if (word.Length == 1)
            {
                return word.ToUpper();
            }

            if (word.Contains('_') || word.Contains('-') || word.Contains(' '))
            {
                var pascalized = CamelizeDefault(word, true);
                return pascalized;
            }

            else
            {
                var pascalized = NormalizeCamelCase(word, true);
                return pascalized;
            }
        }

        public string Camelize(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return word;
            }

            if (word.Length == 1)
            {
                return word.ToLower();
            }

            if (word.Contains('_') || word.Contains('-') || word.Contains(' '))
            {
                var pascalized = CamelizeDefault(word, false);
                return pascalized;
            }

            else
            {
                var pascalized = NormalizeCamelCase(word, false);
                return pascalized;
            }
        }

        public string SnakeCase(string word)
        {
            var snake = Regex.Replace(word, "([A-Za-z])([0-9]+)", "$1_$2");
            snake = Regex.Replace(snake, "([0-9]+)([A-Za-z])", "$1_$2");
            snake = Regex.Replace(snake, "([A-Z]+)([A-Z][a-z])", "$1_$2");
            snake = Regex.Replace(snake, "([a-z]+)([A-Z])", "$1_$2");
            return snake.ToLower();
        }

        public string UpperSnakeCase(string word)
        {
            return SnakeCase(word).ToUpper();
        }

        private string NormalizeCamelCase(string word,
            bool upcaseFirst)
        {
            using (TextWriter writer = new StringWriter())
            using (TextReader reader = new StringReader(word))
            {
                var c1 = (char)reader.Read();
                var c2 = '\0';
                var b = true;
                var upcase = upcaseFirst;

                while (reader.Peek() >= 0)
                {
                    c2 = (char)reader.Read();

                    if ('A' <= c1 && c1 <= 'Z')
                    {
                        if ('A' <= c2 && c2 <= 'Z' || '0' <= c2 && c2 <= '9')
                            writer.Write(b && upcase ? c1 : (char)(c1 - 'A' + 'a'));
                        else
                            writer.Write(upcase ? c1 : (char)(c1 - 'A' + 'a'));

                        b = false;
                    }

                    else if ('a' <= c1 && c1 <= 'z')
                    {
                        writer.Write(b && upcase ? (char)(c1 - 'a' + 'A') : c1);

                        if ('A' <= c2 && c2 <= 'Z')
                        {
                            b = true;
                        }
                        else
                        {
                            b = false;
                        }
                    }

                    else
                    {
                        writer.Write(c1);

                        if ('A' <= c2 && c2 <= 'Z' || 'a' <= c2 && c2 <= 'z')
                        {
                            b = true;
                        }
                    }

                    c1 = c2;
                    upcase = true;
                }

                // last
                if ('A' <= c1 && c1 <= 'Z')
                {
                    if ('A' <= c2 && c2 <= 'Z')
                        writer.Write(b && upcase ? c2 : (char)(c2 - 'A' + 'a'));
                    else
                    {
                        writer.Write(c2);
                    }
                }

                else
                {
                    writer.Write(c2);
                }

                var camelized = writer.ToString();
                return camelized;
            }
        }

        private string CamelizeDefault(string word,
            bool upcaseFirst)
        {
            using (var writer = new StringWriter())
            {
                var isFirst = true;

                foreach (var element in word.Split('_', '-', ' '))
                {
                    writer.Write(upcaseFirst || !isFirst ? element.Substring(0, 1).ToUpper() : element.Substring(0, 1).ToLower());

                    if (element.Length > 1)
                    {
                        writer.Write(element.Substring(1).ToLower());
                    }

                    isFirst = false;
                }

                var camelized = writer.ToString();
                return camelized;
            }
        }
    }
    public class EmployeeManager
    {
            public int RecursionLEvel { get; set; }
        public int BusinessEntityId { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string OrganizationNode { get; set; }
        public string ManagerFirstName{ get; set; }
        public string ManagerLastName { get; set; }
    }

}
