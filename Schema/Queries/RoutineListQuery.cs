using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Schema.Infrastructure;
namespace Schema.Queries
{
    public class RoutineListQuery
    {
        DbConnection connection;
        private string sql = @"select * from INFORMATION_SCHEMA.ROUTINES order by  SPECIFIC_SCHEMA,SPECIFIC_NAME";
        public RoutineListQuery(DbConnection connection)
        {
            this.connection = connection;
        }
        public IEnumerable<Routine> Execute()
        {
            var query = new Query<Routine>(connection, sql);
            return query;
        }
    }
}
