using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Schema.Infrastructure;
namespace Schema.Queries
{
    public class ReferentialConstraintQuery
    {
        protected DbConnection connection;
        protected virtual string sql => @"select 
	REFERENTIAL_CONSTRAINTS.* ,
	TABLES.TABLE_SCHEMA as REFERENCE_TABLE_SCHEMA,
	TABLES.TABLE_NAME as REFERENCE_TABLE_NAME
from 
	INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS

	inner join INFORMATION_SCHEMA.CONSTRAINT_TABLE_USAGE
		on REFERENTIAL_CONSTRAINTS.UNIQUE_CONSTRAINT_SCHEMA = CONSTRAINT_TABLE_USAGE.CONSTRAINT_SCHEMA
		and REFERENTIAL_CONSTRAINTS.UNIQUE_CONSTRAINT_NAME = CONSTRAINT_TABLE_USAGE.CONSTRAINT_NAME

	inner join INFORMATION_SCHEMA.TABLES
		on CONSTRAINT_TABLE_USAGE.TABLE_SCHEMA = TABLES.TABLE_SCHEMA
		and CONSTRAINT_TABLE_USAGE.TABLE_NAME = TABLES.TABLE_NAME
where
	REFERENTIAL_CONSTRAINTS.CONSTRAINT_SCHEMA = @constraintSchema
	and REFERENTIAL_CONSTRAINTS.CONSTRAINT_NAME = @constraintName";
        public ReferentialConstraintQuery(DbConnection connection)
        {
            this.connection = connection;
        }
        public virtual IEnumerable<ReferentialConstraint> Execute(string constraintSchema, string constraintName)
        {
            var query = new Query<ReferentialConstraint>(connection, sql, new { constraintSchema = constraintSchema, constraintName = constraintName });
            return query;
        }
    }
}
