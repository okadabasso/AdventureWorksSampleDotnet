using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace AdventureWorks1.Models5
{
    public partial class UspGetManagerEmployees
    {
        private readonly SampleDbContext  context;
        public UspGetManagerEmployees()
        {
            context = new SampleDbContext ();
        }
        public UspGetManagerEmployees(SampleDbContext  context)
        {
            this.context = context;
        }

        ///<summary>execute command dbo.uspGetManagerEmployees</summary>
        public int Execute(
            int? businessEntityId
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@BusinessEntityID",  businessEntityId);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [dbo].[uspGetManagerEmployees]
@BusinessEntityID = @BusinessEntityID",
                returnValue, 
                p0);

            return (int)returnValue.Value;
        }
        ///<summary>execute query dbo.uspGetManagerEmployees</summary>
        public IEnumerable<T> Query<T>(
            int? businessEntityId
        )
        {
            var p0 = new SqlParameter("@BusinessEntityID",  businessEntityId);

            var result = context.Database.SqlQuery<T>(@"EXEC [dbo].[uspGetManagerEmployees]
@BusinessEntityID = @BusinessEntityID", 
                p0);

            return result;
        }

    }
}
