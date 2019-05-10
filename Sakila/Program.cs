using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MySql.Data.EntityFramework;
namespace Sakila
{
    class Program
    {
        static void Main(string[] args)
        {


            using (var context = new Sakila.Models.SampleDbContext())
            {
                var query = context.Country.ToList();
                foreach (var country in query)
                {
                    Console.WriteLine($"{country.CountryId} {country.Country1}");
                    foreach (var city in country.Cities)
                    {
                        Console.WriteLine($"\t{city.CityId} {city.City1}");

                        foreach (var address in city.Addresses)
                        {
                            Console.WriteLine($"\t\t{address.Address1} {address.Address2}");

                        }
                    }

                }

            }

            using (var context = new NewContext())
            {
                var query = context.country.ToList();
                foreach (var country in query)
                {
                    Console.WriteLine($"{country.country_id} {country.country1}");
                }

            }

            Console.ReadLine();


        }
    }
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class NewContext : DbContext
    {
       
        public NewContext()
            : base("name=sampledb")
        {

        }
        public DbSet<country> country { get; set; }
    }
    [Table("country")]
    public class country {
        [Key]
        [Column("country_id", Order = 0)]
        public short country_id { get; set; }

        [Column("country")]
        public string country1 { get; set; }
        public DateTime? last_update { get; set; }

    }

}
