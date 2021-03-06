using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace AdventureWorks1.Models5
{
    public partial class SpGetEmployeePersonInfoAsOf
    {
        private readonly SampleDbContext  context;
        public SpGetEmployeePersonInfoAsOf()
        {
            context = new SampleDbContext ();
        }
        public SpGetEmployeePersonInfoAsOf(SampleDbContext  context)
        {
            this.context = context;
        }

        ///<summary>execute command HumanResources.sp_GetEmployee_Person_Info_AsOf</summary>
        public int Execute(
            DateTime? asOf
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@asOf",  asOf);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [HumanResources].[sp_GetEmployee_Person_Info_AsOf]
@asOf = @asOf",
                returnValue, 
                p0);

            return (int)returnValue.Value;
        }
        ///<summary>execute query HumanResources.sp_GetEmployee_Person_Info_AsOf</summary>
        public IEnumerable<T> Query<T>(
            DateTime? asOf
        )
        {
            var p0 = new SqlParameter("@asOf",  asOf);

            var result = context.Database.SqlQuery<T>(@"EXEC [HumanResources].[sp_GetEmployee_Person_Info_AsOf]
@asOf = @asOf", 
                p0);

            return result;
        }

    }
}
