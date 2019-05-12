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
                using(var tx = context.Database.BeginTransaction())
                {
                    var country = context.Countries.FirstOrDefault(x => x.CountryId == 50);
                    var city = new Sakila.Models.City {
                        City1 = "Tosa",
                         Country = country,
                        LastUpdate = DateTime.Now
                    };
                    var address = new Sakila.Models.Address {
                        Address1 = "hewa",
                        Address2 = "kamoji",
                        District = "kouchi",
                        Phone = "044-1111-2222",
                        LastUpdate = DateTime.Now,
                        City = city
                    };
                    context.Cities.Add(city);

                    context.SaveChanges();
                    city.Addresses.Add(address);
                    //context.Addresses.Add(address);
                    context.SaveChanges();

                    tx.Commit();
                }
                var query = context.Countries
                    .Include(x => x.Cities)
                    .Include(x => x.Cities.Select(y => y.Addresses)) 
                    .Where(x => x.Country1 == "Japan")
                    .OrderBy(x => x.CountryId);
                foreach (var country in query)  
                {

                    Console.WriteLine($"{country.CountryId} {country.Country1}");
                    foreach (var city in country.Cities.OrderBy(x => x.CityId))
                    {
                        Console.WriteLine($"\t{city.CityId} {city.City1}");

                        foreach (var address in city.Addresses.OrderBy(x => x.AddressId))
                        {
                            Console.WriteLine($"\t\t{address.Address1} {address.Address2}");

                        }
                    }

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
