using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace Sample.Entities
{
    public partial class SpGetemployeePersonInfoAsof
    {
        private readonly SampleDbContext context;
        public SpGetemployeePersonInfoAsof()
        {
            context = new SampleDbContext();
        }
        public SpGetemployeePersonInfoAsof(SampleDbContext context)
        {
            this.context = context;
        }

        public int Execute(
            DateTime? asOf
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@asOf",  asOf);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [HumanResources].[sp_GetEmployee_Person_Info_AsOf] @asOf = @asOf",
                returnValue, p0);

            return (int)returnValue.Value;
        }
        public IEnumerable<T> Query<T>(
            DateTime? asOf        )
        {
            var p0 = new SqlParameter("@asOf",  asOf);

            var result = context.Database.SqlQuery<T>(@"EXEC [HumanResources].[sp_GetEmployee_Person_Info_AsOf] @asOf = @asOf"
                , p0);

            return result;
        }

    }
}
