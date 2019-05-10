using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Schema.Infrastructure;
namespace Schema.MySql.Queries
{
    public class ReferentialConstraintQuery : Schema.Queries.ReferentialConstraintQuery
    {
        protected override string sql => @"select 
	REFERENTIAL_CONSTRAINTS.* ,
	REFERENTIAL_CONSTRAINTS.CONSTRAINT_SCHEMA as REFERENCE_TABLE_SCHEMA,
	REFERENTIAL_CONSTRAINTS.REFERENCED_TABLE_NAME as REFERENCE_TABLE_NAME
from 
	INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS

where
	REFERENTIAL_CONSTRAINTS.CONSTRAINT_SCHEMA = @constraintSchema
	and REFERENTIAL_CONSTRAINTS.CONSTRAINT_NAME = @constraintName";
        public ReferentialConstraintQuery(DbConnection connection)
            : base(connection)
        {
        }
    }
}
