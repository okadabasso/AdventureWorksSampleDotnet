using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Schema;
using Schema.Queries;
using MySql.Data.MySqlClient;
namespace Schema.MySql
{
    public class MySqlSchemaManager : SchemaManager
    {
        protected override ColumnListQuery columnQuery => new Queries.ColumnListQuery(connection);
        protected override IndexListQuery indexQuery => new Queries.IndexListQuery(connection);
        protected override IndexColumnListQuery indexColumnQuery => new Queries.IndexColumnListQuery(connection);

        protected override ReferentialConstraintQuery referentialConstraintQuery => new Queries.ReferentialConstraintQuery(connection);
        public MySqlSchemaManager(DbConnection connection)
            : base(connection)
        {

        }
        public MySqlSchemaManager(string connectionString) 
            : base(new global::MySql.Data.MySqlClient.MySqlConnection(connectionString) )
        {
        }
        public MySqlSchemaManager(string connectionString, string providerName)
            : base(new global::MySql.Data.MySqlClient.MySqlConnection(connectionString))
        {
        }

    }
}
