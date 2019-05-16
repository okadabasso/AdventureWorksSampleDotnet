using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using global::Schema.MySql;

namespace Sakila.Schema
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "server= localhost;port=13306;database=sakila;uid=sakilauser;pwd=sakilauser";

            var schemaManager = new MySqlSchemaManager(connectionString);
            var associations = schemaManager.GetAssociations().OrderBy(x => x.PrincipalRole.RoleName);
            foreach (var association in associations)
            {
                var principalMultiplicity = (association.PrincipalRole.Required ? "" : "0..") + association.PrincipalRole.Multiplicity;
                var dependentMultiplicity = (association.DependentRole.Required ? "1.." : "0..") + association.DependentRole.Multiplicity;

                Console.WriteLine($"{association.PrincipalRole.RoleName}({association.PrincipalRole.ReferenceName}) {principalMultiplicity}----{dependentMultiplicity} {association.DependentRole.RoleName}({association.DependentRole.ReferenceName})");

                var e1 = association.PrincipalRole.Columns.GetEnumerator();
                var e2 = association.DependentRole.Columns.GetEnumerator();
                while (e1.MoveNext())
                {
                    e2.MoveNext();
                    Console.WriteLine($"\t{e1.Current} -- {e2.Current}");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
