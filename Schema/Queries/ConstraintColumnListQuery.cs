﻿using System;
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
	and KEY_COLUMN_USAGE.TABLE_SCHEMA = @tableSchema
	and KEY_COLUMN_USAGE.TABLE_NAME = @tableName
order by
	KEY_COLUMN_USAGE.ORDINAL_POSITION
";
        public ConstraintColumnListQuery(DbConnection connection)
        {
            this.connection = connection;
        }
        public IEnumerable<KeyColumnUsage> Execute(string constraintSchema, string constraintName, string tableSchema, string tableName)
        {
            var query = new Query<KeyColumnUsage>(connection, sql, new { constraintSchema = constraintSchema, constraintName = constraintName, tableSchema = tableSchema, tableName = tableName });
            return query;
        }
    }
}
