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
            var connectionString = "server= localhost;database=sakila;uid=sakilauser;pwd=sakilauser";

            var schemaManager = new MySqlSchemaManager(connectionString);
            var routines = schemaManager.GetRoutines();

            foreach(var r in routines)
            {
                Console.WriteLine(r.RoutineName);
                foreach(var p in r.Parameters)
                {
                    Console.WriteLine(p.ParameterName);
                    Console.WriteLine(p.ObjectName);

                }
            }
            Console.ReadLine();
        }
    }
}
