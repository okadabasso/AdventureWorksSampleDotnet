using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Schema.Infrastructure;

namespace Schema.Queries
{
    public class IndexListQuery
    {
        protected DbConnection connection;
        protected virtual string sql => @"select
	*
from 
	sys.indexes
where
	indexes.object_id = object_id(@tableSchema + '.' + @tableName)
order by
    indexes.index_id
";
        public IndexListQuery(DbConnection connection)
        {
            this.connection = connection;
        }
        public virtual IEnumerable<Index> Execute(string tableSchema, string tableName)
        {
            var query = new Query<Index>(connection, sql, new { tableSchema = tableSchema, tableName = tableName });
            return query;
        }
    }
}
