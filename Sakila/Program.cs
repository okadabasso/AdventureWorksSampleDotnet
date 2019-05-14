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
                var query = context.Films
                    .Include(x => x.Language)
                    .Include(x => x.FilmActors).Include(x => x.FilmActors.Select(y => y.Actor));
                foreach(var film in query)
                {
                    Console.WriteLine($"{film.Description} {film.Language.Name}");
                    foreach(var actor in film.FilmActors)
                    {
                        Console.WriteLine($"{actor.Actor.FirstName} {actor.Actor.LastName}");

                    }
                }
            }

            Console.ReadLine();
        }
    }

}
