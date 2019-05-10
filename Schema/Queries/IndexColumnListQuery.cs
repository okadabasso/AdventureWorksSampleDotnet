using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Schema.Infrastructure;
namespace Schema.Queries
{
    public class IndexColumnListQuery
    {
        protected DbConnection connection;
        protected virtual string sql => @"select
	SCHEMA_NAME(objects.schema_id) as TABLE_SCHEMA,
	objects.name as TABLE_NAME,
	indexes.name as INDEX_NAME,
	indexes.type_desc as TYPE_DESC,
	indexes.index_id as INDEX_ID,
	index_columns.index_column_id as INDEX_COLUMN_ID,
	columns.name as COLUMN_NAME
from 
	sys.objects
	inner join sys.indexes
		on objects.object_id = indexes.object_id
	inner join sys.index_columns
		on objects.object_id = index_columns.object_id
		and indexes.index_id = index_columns.index_id
	inner join sys.columns
		on index_columns.object_id = columns.object_id
		and index_columns.column_id = columns.column_id
where
	objects.object_id = object_id(@tableSchema + '.' + @tableName)
	-- and indexes.index_id = 2
order by
	index_columns.index_id,
	index_columns.index_column_id
";
        public IndexColumnListQuery(DbConnection connection)
        {
            this.connection = connection;
        }
        public virtual IEnumerable<IndexColumn> Execute(string tableSchema, string tableName)
        {
            var query = new Query<IndexColumn>(connection, sql, new { tableSchema = tableSchema, tableName = tableName });
            return query;
        }
    }
}
