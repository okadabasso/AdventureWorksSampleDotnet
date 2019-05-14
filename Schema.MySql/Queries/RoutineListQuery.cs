using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Schema.Infrastructure;
namespace Schema.MySql.Queries
{
    public class RoutineListQuery : Schema.Queries.RoutineListQuery
    {
        protected override  string sql => @"select * from INFORMATION_SCHEMA.ROUTINES order by  SPECIFIC_NAME";

        public RoutineListQuery(DbConnection connection)
            : base(connection)
        {
        }
    }
}
