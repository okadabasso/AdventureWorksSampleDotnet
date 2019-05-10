﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using Schema.Infrastructure;

namespace Schema.MySql.Queries
{
    public class ColumnListQuery : Schema.Queries.ColumnListQuery
    {
        protected override string sql => @"
select
	COLUMNS.*,
	case COLUMNS.EXTRA
		WHEN 'auto_increment' THEN 'YES' 
		ELSE 'NO' 
	END IS_IDENTITY,
	columns.column_comment as description
from
	INFORMATION_SCHEMA.COLUMNS

where
	COLUMNS.TABLE_SCHEMA = @tableSchema
	and COLUMNS.TABLE_NAME = @tableName

order by
	COLUMNS.ORDINAL_POSITION";
        public ColumnListQuery(DbConnection connection)
            : base(connection)
        {

        }
    }
}
