using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Schema.Infrastructure;

namespace Schema.Queries
{
    public class ColumnListQuery
    {
        protected DbConnection connection;
        protected virtual string sql => @"
select
	COLUMNS.*,
	CASE COLUMNPROPERTY (OBJECT_ID(COLUMNS.TABLE_SCHEMA + '.' + COLUMNS.TABLE_NAME ),COLUMNS.COLUMN_NAME ,'IsIdentity') 
		WHEN 1 THEN 'YES' 
		ELSE 'NO' 
	END IS_IDENTITY,
	e.value as DESCRIPTION
from
	INFORMATION_SCHEMA.COLUMNS


	left join sys.fn_listextendedproperty(N'MS_Description', N'schema',@tableSchema, N'table', @tableName, N'column', default) AS e  
    ON COLUMNS.COLUMN_NAME = e.objname COLLATE SQL_Latin1_General_CP1_CI_AS  
where
	COLUMNS.TABLE_SCHEMA = @tableSchema
	and COLUMNS.TABLE_NAME = @tableName

order by
	COLUMNS.ORDINAL_POSITION";
        public ColumnListQuery(DbConnection connection)
        {
            this.connection = connection;
        }
        public Query<Column> Execute(string tableSchema, string tableName)
        {
            var query = new Query<Column>(connection, sql, new { tableSchema = tableSchema, tableName = tableName });
            return query;
        }
    }
}
