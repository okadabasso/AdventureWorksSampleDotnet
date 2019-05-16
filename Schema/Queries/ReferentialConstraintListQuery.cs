using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Schema.Infrastructure;

namespace Schema.Queries
{
    public class ReferentialConstraintListQuery
    {
        protected DbConnection connection;
        protected virtual string sql => @"select 
	REFERENTIAL_CONSTRAINTS.* ,
	BASE_TABLE.TABLE_SCHEMA as BASE_TABLE_SCHEMA,
	BASE_TABLE.TABLE_NAME as BASE_TABLE_NAME,
	REFERENCE_TABLE.TABLE_SCHEMA as REFERENCE_TABLE_SCHEMA,
	REFERENCE_TABLE.TABLE_NAME as REFERENCE_TABLE_NAME
from 
	INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS

	inner join INFORMATION_SCHEMA.CONSTRAINT_TABLE_USAGE as BASE_TABLE
		on REFERENTIAL_CONSTRAINTS.CONSTRAINT_SCHEMA = BASE_TABLE.CONSTRAINT_SCHEMA
		and REFERENTIAL_CONSTRAINTS.CONSTRAINT_NAME = BASE_TABLE.CONSTRAINT_NAME

	inner join INFORMATION_SCHEMA.CONSTRAINT_TABLE_USAGE as REFERENCE_TABLE
		on REFERENTIAL_CONSTRAINTS.UNIQUE_CONSTRAINT_SCHEMA = REFERENCE_TABLE.CONSTRAINT_SCHEMA
		and REFERENTIAL_CONSTRAINTS.UNIQUE_CONSTRAINT_NAME = REFERENCE_TABLE.CONSTRAINT_NAME

order by 
	BASE_TABLE.TABLE_SCHEMA,
	BASE_TABLE.TABLE_NAME,
	REFERENTIAL_CONSTRAINTS.CONSTRAINT_SCHEMA,
	REFERENTIAL_CONSTRAINTS.CONSTRAINT_NAME,
	REFERENCE_TABLE.TABLE_SCHEMA,
	REFERENCE_TABLE.TABLE_NAME
";
        public ReferentialConstraintListQuery (DbConnection connection)
        {
            this.connection = connection;
        }
        public virtual IEnumerable<ReferentialConstraint> Execute(string schema = null)
        {
            var query = new Query<ReferentialConstraint>(connection, sql);
            return query;
        }
    }
}
