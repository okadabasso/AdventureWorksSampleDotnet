using System.Collections.Generic;
using System.Data.Common;
using Schema.Infrastructure;
namespace Schema.Queries
{
    public class SequenceListQuery
    {
        DbConnection connection;
        private string sql = @"select 
    * 
from 
    INFORMATION_SCHEMA.SEQUENCES 
order by  
    SEQUENCE_SCHEMA,
    SEQUENCE_NAME";
        public SequenceListQuery(DbConnection connection)
        {
            this.connection = connection;
        }
        public IEnumerable<Sequence> Execute()
        {
            var query = new Query<Sequence>(connection, sql);
            return query;
        }
    }
}
