using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Schema;
using Schema.Queries;

namespace Schema.MySql
{
    public class MySqlSchemaManager : SchemaManager
    {
        protected override IndexListQuery indexQuery => new Queries.IndexListQuery(connection);
        protected override IndexColumnListQuery indexColumnQuery => new Queries.IndexColumnListQuery(connection);
        public MySqlSchemaManager(DbConnection connection)
            : base(connection)
        {

        }
        public MySqlSchemaManager(string connectionString) 
            : base(connectionString)
        {
        }
        public MySqlSchemaManager(string connectionString, string providerName)
            : base(connectionString, providerName)
        {
        }

    }
}
