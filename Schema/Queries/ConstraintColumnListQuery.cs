using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Schema.Infrastructure;
namespace Schema.Queries
{
    public class ConstraintColumnListQuery
    {
        DbConnection connection;
        private string sql = @"select
	*
from
	INFORMATION_SCHEMA.KEY_COLUMN_USAGE
where
	KEY_COLUMN_USAGE.CONSTRAINT_SCHEMA = @constraintSchema
	and KEY_COLUMN_USAGE.CONSTRAINT_NAME = @constraintName
order by
	KEY_COLUMN_USAGE.ORDINAL_POSITION
";
        public ConstraintColumnListQuery(DbConnection connection)
        {
            this.connection = connection;
        }
        public Query<KeyColumnUsage> Execute(string constraintSchema, string constraintName)
        {
            var query = new Query<KeyColumnUsage>(connection, sql, new { constraintSchema = constraintSchema, constraintName = constraintName });
            return query;
        }
    }
}
