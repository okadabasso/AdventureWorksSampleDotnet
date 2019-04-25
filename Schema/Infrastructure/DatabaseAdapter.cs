using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Configuration;
namespace Schema.Infrastructure
{
    public class DatabaseAdapter : IDisposable
    {
        private readonly DbConnection connection;
        public DatabaseAdapter()
        {
            var factory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings[0].ProviderName);
            this.connection = factory.CreateConnection();
            this.connection.ConnectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
        }
        public DatabaseAdapter(DbConnection connection)
        {
            this.connection = connection;
        }
        public DatabaseAdapter(string name)
        {
            var factory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings[name].ProviderName);
            this.connection = factory.CreateConnection();
            this.connection.ConnectionString = ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public void Dispose()
        {
            if(connection != null)
            {
                connection.Dispose();
            }
        }

        public Query<T> Query<T>(string sql, params object[] parameters)
        {
            return new Query<T>(this.connection, sql, parameters);
        }
    }
}
