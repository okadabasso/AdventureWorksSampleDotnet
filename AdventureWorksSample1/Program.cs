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
using Schema.Infrastructure;

namespace AdventureWorksSample1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
 
            // NamingConventionSample();
            Console.ReadLine();
        }
        static void NamingConventionSample()
        {
            Console.WriteLine(NamingConvention.Pascalize("abc_def_ghi"));
            Console.WriteLine(NamingConvention.Pascalize("ufnSample1_WordBreak"));
            Console.WriteLine(NamingConvention.Pascalize("UFNSample1__WordBreak"));

            Console.WriteLine(NamingConvention.Camelize("abc_def_ghi"));
            Console.WriteLine(NamingConvention.Camelize("ufnSample1_WordBreak"));
            Console.WriteLine(NamingConvention.Camelize("UFNSample1_WordBreak"));

            Console.WriteLine(NamingConvention.Snake("table1"));
            Console.WriteLine(NamingConvention.Snake("UFNSample1__WordBreak"));

        }
        static void SampleQuery()
        {
            using (var context = new AdventureWorks1.Models6.SampleDbContext())
            {
                foreach(var item in context.Table1.Where(x => x.Table2s.Any()))
                {
                    Console.WriteLine($"{item.Id}, {item.Name}");
                    foreach(var innerItem in item.Table2s)
                    {
                        Console.WriteLine($"\t{innerItem.Id}, {innerItem.Name}");
                    }
                }
            }
        }
        static void SampleInsert()
        {
            using (var context = new AdventureWorks1.Models6.SampleDbContext())
                using(var trx = context.Database.BeginTransaction())
            {
                var item = context.Table1.First(x => x.Id == 5);
                var item2 = new AdventureWorks1.Models6.Table2() {
                    Name = "entry " + item.Id.ToString() + " - " + DateTime.Now.ToString(),
                    Table1 = item
                };
                context.Table2.Add(item2);
                context.SaveChanges();
                trx.Commit();
            }
        }
        static void SampleDbSequence()
        {
            using (var context = new AdventureWorks1.Models6.SampleDbContext())
            {
                var sequence = new AdventureWorks1.Models6.SeqSampleTable1(context);
                var result = sequence.NextValue();
                Console.WriteLine("result = {0}", result);

                result = sequence.NextValue();
                Console.WriteLine("result = {0}", result);
            }
        }
        static void SampleDbFunctionExecute()
        {
            using (var context = new AdventureWorks1.Models5.SampleDbContext())
            {
                var procedure = new AdventureWorks1.Models5.UfnGetDocumentStatusText();
                var result = procedure.Execute(2);
                Console.WriteLine("result = {0}", result);
            }
        }
        static void SampleDbProcedureExecute()
        {
            using (var context = new AdventureWorks1.Models5.SampleDbContext())
            {
                var procedure = new AdventureWorks1.Models5.UspGetEmployeeManagers();
                var query = procedure.Execute(290);

            }
        }
        static void SampleDbProcedureQuery()
        {
            using (var context = new AdventureWorks1.Models5.SampleDbContext())
            {
                var procedure = new AdventureWorks1.Models5.UspGetEmployeeManagers();
                var query = procedure.Query<EmployeeManager>(290);
                foreach(var item in query)
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName} {item.ManagerFirstName} {item.ManagerLastName}");
                }
            }
        }
        static void SampleQuery(string name)
        {
            using(var context = new AdventureWorks1.Models5.SampleDbContext())
            {
                var query = context.SpecialOfferProduct.Where(x => x.Product.Name.StartsWith(name));
                foreach(var offer in query)
                {
                    Console.WriteLine($"{offer.SpecialOfferId} {offer.Product.Name}");
                    foreach(var n in offer.SalesOrderDetails)
                    {
                        Console.WriteLine($"\t{n.LineTotal} {n.OrderQty}");

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
