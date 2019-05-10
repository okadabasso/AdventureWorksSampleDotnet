using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Schema.Infrastructure;
namespace Schema.Queries
{
    public class TableConstraintListQuery
    {
        private string sql = @"select
	*
from
	INFORMATION_SCHEMA.TABLE_CONSTRAINTS
where
	TABLE_CONSTRAINTS.TABLE_SCHEMA = @tableSchema
	and TABLE_CONSTRAINTS.TABLE_NAME = @tableName
order by
    CONSTRAINT_SCHEMA,
    CONSTRAINT_NAME
";
        DbConnection connection;
        public TableConstraintListQuery(DbConnection connection)
        {
            this.connection = connection;
        }
        public IEnumerable<TableConstraint> Execute(string tableSchema, string tableName)
        {
            var query = new Query<TableConstraint>(connection, sql, new { tableSchema = tableSchema, tableName = tableName });
            return query;
        }
    }
}
