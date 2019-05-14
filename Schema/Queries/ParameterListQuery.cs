using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Schema.Infrastructure;
namespace Schema.Queries
{
    public class ParameterListQuery
    {
        protected DbConnection connection;
        protected virtual string sql => @"select 
    * 
from 
    INFORMATION_SCHEMA.PARAMETERS 
where 
    SPECIFIC_SCHEMA = @specificSchema
    and SPECIFIC_NAME = @specificName
order by  
    SPECIFIC_SCHEMA,SPECIFIC_NAME, ORDINAL_POSITION";

        public ParameterListQuery(DbConnection connection)
        {
            this.connection = connection;
        }
        public virtual IEnumerable<Parameter> Execute(string specificSchema, string specificName)
        {
            var query = new Query<Parameter>(connection, sql, new { specificSchema = specificSchema, specificName = specificName });
            return query;
        }
    }
}
