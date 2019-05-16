using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schema.Infrastructure;
using global::MySql.Data.MySqlClient;
namespace Schema.MySql.Queries
{
    public class ReferentialConstraintListQuery : Schema.Queries.ReferentialConstraintListQuery
    {
        protected override string sql => @"select 
	REFERENTIAL_CONSTRAINTS.* ,
	REFERENTIAL_CONSTRAINTS.CONSTRAINT_SCHEMA as BASE_TABLE_SCHEMA,
	REFERENTIAL_CONSTRAINTS.TABLE_NAME as BASE_TABLE_NAME,
	REFERENTIAL_CONSTRAINTS.CONSTRAINT_SCHEMA as REFERENCE_TABLE_SCHEMA,
	REFERENTIAL_CONSTRAINTS.REFERENCED_TABLE_NAME as REFERENCE_TABLE_NAME
from 
	INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS

where
	REFERENTIAL_CONSTRAINTS.CONSTRAINT_SCHEMA = @constraintSchema
order by 
	REFERENTIAL_CONSTRAINTS.CONSTRAINT_SCHEMA,
	REFERENTIAL_CONSTRAINTS.TABLE_NAME,
	REFERENTIAL_CONSTRAINTS.CONSTRAINT_SCHEMA,
	REFERENTIAL_CONSTRAINTS.CONSTRAINT_NAME,
	REFERENTIAL_CONSTRAINTS.CONSTRAINT_SCHEMA,
	REFERENTIAL_CONSTRAINTS.REFERENCED_TABLE_NAME
";
        public ReferentialConstraintListQuery(DbConnection connection)
            : base(connection)
        {

        }
        public override IEnumerable<ReferentialConstraint> Execute(string schema = null)
        {
            schema = CurrentDatabase();
            var query = new Query<ReferentialConstraint>(connection, sql, new { constraintSchema = schema });
            return query;
        }

        private string CurrentDatabase()
        {
            connection.Open();
            var command = new MySqlCommand("select DATABASE();", connection as MySqlConnection);
            var result = (string) command.ExecuteScalar();
            connection.Close();
            return result;
        }
    }
}
