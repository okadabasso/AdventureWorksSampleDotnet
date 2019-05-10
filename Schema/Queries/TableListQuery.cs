using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Schema.Infrastructure;
namespace Schema.Queries
{
    public class TableListQuery
    {
        DbConnection connection;
        public TableListQuery(DbConnection connection)
        {
            this.connection = connection;
        }
        public IEnumerable<Table> Execute()
        {
            var query = new Query<Table>(connection, "select * from INFORMATION_SCHEMA.TABLES where TABLE_TYPE='BASE TABLE' order by TABLE_SCHEMA, TABLE_NAME");
            return query;
        } 
    }
}
