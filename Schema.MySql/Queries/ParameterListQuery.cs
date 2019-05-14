using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Schema.Infrastructure;
namespace Schema.MySql.Queries
{
    public class ParameterListQuery : Schema.Queries.ParameterListQuery
    {
        protected override string sql => @"select 
    * 
from 
    INFORMATION_SCHEMA.PARAMETERS 
where 
    SPECIFIC_NAME = @specificName
order by  
    ORDINAL_POSITION";

        public ParameterListQuery(DbConnection connection)
            : base(connection)
        {
        }
        public override IEnumerable<Parameter> Execute(string specificSchema, string specificName)
        {
            var query = new Query<Parameter>(connection, sql, new { specificName = specificName });
            return query;
        }
    }
}
