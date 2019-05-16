using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schema.Infrastructure;

namespace Schema.Queries
{
    public class KeyColumnUsageQuery
    {
        DbConnection connection;
        private string sql = @"select
	KEY_COLUMN_USAGE.*,
	COLUMNS.DATA_TYPE,
	COLUMNS.IS_NULLABLE,
    TABLE_CONSTRAINTS.CONSTRAINT_TYPE as CONSTRAINT_TYPE
from
	INFORMATION_SCHEMA.TABLE_CONSTRAINTS

	inner join INFORMATION_SCHEMA.KEY_COLUMN_USAGE
		on TABLE_CONSTRAINTS.CONSTRAINT_SCHEMA = KEY_COLUMN_USAGE.CONSTRAINT_SCHEMA
		and TABLE_CONSTRAINTS.CONSTRAINT_NAME = KEY_COLUMN_USAGE.CONSTRAINT_NAME

inner join INFORMATION_SCHEMA.COLUMNS
		on KEY_COLUMN_USAGE.TABLE_SCHEMA = COLUMNS.TABLE_SCHEMA
		and KEY_COLUMN_USAGE.TABLE_NAME = COLUMNS.TABLE_NAME
		and KEY_COLUMN_USAGE.COLUMN_NAME = COLUMNS.COLUMN_NAME

where
	TABLE_CONSTRAINTS.TABLE_SCHEMA = @tableSchema
	and TABLE_CONSTRAINTS.TABLE_NAME = @tableName

order by
	TABLE_CONSTRAINTS.TABLE_SCHEMA,
	TABLE_CONSTRAINTS.TABLE_NAME,
	TABLE_CONSTRAINTS.CONSTRAINT_SCHEMA,
	TABLE_CONSTRAINTS.CONSTRAINT_NAME,
	KEY_COLUMN_USAGE.ORDINAL_POSITION
";
        public KeyColumnUsageQuery(DbConnection connection)
        {
            this.connection = connection;
        }
        public IEnumerable<KeyColumnUsage> Execute(string tableSchema, string tableName)
        {
            var query = new Query<KeyColumnUsage>(connection, sql, new {
                tableSchema = tableSchema,
                tableName = tableName
            });
            return query;
        }
    }
}
