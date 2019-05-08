using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace Sample.Entities
{
    public partial class CustomerAccessPredicate
    {
        private readonly SampleDbContext context;
        public CustomerAccessPredicate()
        {
            context = new SampleDbContext();
        }
        public CustomerAccessPredicate(SampleDbContext context)
        {
            this.context = context;
        }

        public int Execute(
            int? territoryId
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@TerritoryID",  territoryId);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [Security].[customerAccessPredicate] @TerritoryID = @TerritoryID",
                returnValue, p0);

            return (int)returnValue.Value;
        }
        public IEnumerable<T> Query<T>(
            int? territoryId        )
        {
            var p0 = new SqlParameter("@TerritoryID",  territoryId);

            var result = context.Database.SqlQuery<T>(@"EXEC [Security].[customerAccessPredicate] @TerritoryID = @TerritoryID"
                , p0);

            return result;
        }

    }
}
