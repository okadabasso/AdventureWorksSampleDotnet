using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace Sample.Entities
{
    public partial class UfnGetContactInformation
    {
        private readonly SampleDbContext context;
        public UfnGetContactInformation()
        {
            context = new SampleDbContext();
        }
        public UfnGetContactInformation(SampleDbContext context)
        {
            this.context = context;
        }

        public int Execute(
            int? personId
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@PersonID",  personId);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [dbo].[ufnGetContactInformation] @PersonID = @PersonID",
                returnValue, p0);

            return (int)returnValue.Value;
        }
        public IEnumerable<T> Query<T>(
            int? personId        )
        {
            var p0 = new SqlParameter("@PersonID",  personId);

            var result = context.Database.SqlQuery<T>(@"EXEC [dbo].[ufnGetContactInformation] @PersonID = @PersonID"
                , p0);

            return result;
        }

    }
}
