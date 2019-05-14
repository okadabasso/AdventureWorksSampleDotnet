using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;


namespace SakilaCore
{
    public class Program
    {
        private static IServiceProvider BuildDi(IConfiguration config)
        {
            return new ServiceCollection()
               .AddLogging(loggingBuilder => {
          // configure Logging with NLog
          loggingBuilder.ClearProviders();
                   loggingBuilder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
                   loggingBuilder.AddNLog(config);
               })
               .BuildServiceProvider();
        }
        public static void Main(string[] args)
        {
            var logger = LogManager.GetCurrentClassLogger();
            try
            {
                var config = new ConfigurationBuilder()
                   .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                   .Build();

                var servicesProvider = BuildDi(config);
                using (servicesProvider as IDisposable)
                {
                    using (var context = new SakilaCore.Models.SampleDbContext())
                    {
                        var query = context.Films
                            .Include(x => x.Language)
                            .Include(x => x.FilmActors).ThenInclude(x => x.Actor);
                        foreach (var film in query)
                        {
                            Console.WriteLine($"{film.Description} {film.Language.Name}");
                            foreach (var actor in film.FilmActors)
                            {
                                Console.WriteLine($"{actor.Actor.FirstName} {actor.Actor.LastName}");

                            }
                        }
                    }
                    Console.WriteLine("Press ANY key to exit");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                // NLog: catch any exception and log it.
                logger.Error(ex, "Stopped program because of exception");
                throw;
            }

        }
    }
}
