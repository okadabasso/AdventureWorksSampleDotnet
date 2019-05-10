using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Schema.Infrastructure;
using Schema.Queries;
namespace Schema.MySql.Queries
{
    public class IndexColumnListQuery : Schema.Queries.IndexColumnListQuery
    {
        protected override string sql => @"show index from {0};";
        public IndexColumnListQuery(DbConnection connection)
            : base(connection)
        {
        }
        public override IEnumerable<IndexColumn> Execute(string tableSchema, string tableName)
        {
            var query = new Query<MySqlIndex>(connection, string.Format(sql, tableName))
                .GroupBy(x => x.KeyName)
                .SelectMany((x, keyIndex) => 
                    x.Select(item => 
                    new IndexColumn {
                        TableSchema = tableSchema,
                        TableName = item.Table,
                        TypeDesc = item.IndexType,
                        IndexId = keyIndex,
                        IndexColumnId = item.SeqInIndex,
                        ColumnName = item.ColumnName
                    })
                );

            return query;
        }
    }
}
