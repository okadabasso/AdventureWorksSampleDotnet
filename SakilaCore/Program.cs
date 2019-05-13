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
                        var addresses = context.Addresses
                            .Include(x => x.City)
                            .Include(x => x.City.Country)
                            .Include(x => x.Stores)
                            .Where(x => x.Stores.Any())
                            ;
                        foreach(var address in addresses)
                        {
                            Console.WriteLine($"{address.City?.City1} {address.Address1} country={address.City?.Country?.Country1} ");
                            foreach (var store in address.Stores)
                            {

                                Console.WriteLine($"\t{store.StoreId}");
                                var store2= context.Stores.Include(x => x.Staff).Where(x => x.StoreId == store.StoreId).FirstOrDefault();
                                foreach(var staff in store2.Staffs)
                                {
                                    Console.WriteLine($"\t{staff.Username}");

                                }

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
