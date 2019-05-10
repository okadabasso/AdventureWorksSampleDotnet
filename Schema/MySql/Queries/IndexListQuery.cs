using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Schema.Infrastructure;
using Schema.MySql;
namespace Schema.MySql.Queries
{
    public class IndexListQuery : Schema.Queries.IndexListQuery
    {
        protected override string sql => @"show index from {0};";
        public IndexListQuery(DbConnection connection) : base(connection)
        {

        }
        public override IEnumerable<Index> Execute(string tableSchema, string tableName)
        {
            var query = new Query<Schema.MySql.MySqlIndex>(connection, string.Format(sql, tableName))
                .GroupBy(x => new { x.Table, x.KeyName, x.NonUnique })
                .Select(x => x.First())
                .Select((x, index) => new Index{
                    Name = x.KeyName,
                    IndexId = index,
                    TypeDesc = x.IndexType,
                    IsUnique = x.NonUnique == 0
                });



            return query;
        }
    }
}
