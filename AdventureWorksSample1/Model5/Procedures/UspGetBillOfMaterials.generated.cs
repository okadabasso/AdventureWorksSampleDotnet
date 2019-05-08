using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace Sample.Entities
{
    public partial class UspGetBillOfMaterials
    {
        private readonly SampleDbContext context;
        public UspGetBillOfMaterials()
        {
            context = new SampleDbContext();
        }
        public UspGetBillOfMaterials(SampleDbContext context)
        {
            this.context = context;
        }

        ///<summary>execute command dbo.uspGetBillOfMaterials</summary>
        public int Execute(
            int? startProductId, 
            DateTime? checkDate
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@StartProductID",  startProductId);
            var p1 = new SqlParameter("@CheckDate",  checkDate);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [dbo].[uspGetBillOfMaterials]
@StartProductID = @StartProductID,
@CheckDate = @CheckDate",
                returnValue, 
                p0, 
                p1);

            return (int)returnValue.Value;
        }
        ///<summary>execute query dbo.uspGetBillOfMaterials</summary>
        public IEnumerable<T> Query<T>(
            int? startProductId, 
            DateTime? checkDate
        )
        {
            var p0 = new SqlParameter("@StartProductID",  startProductId);
            var p1 = new SqlParameter("@CheckDate",  checkDate);

            var result = context.Database.SqlQuery<T>(@"EXEC [dbo].[uspGetBillOfMaterials]
@StartProductID = @StartProductID,
@CheckDate = @CheckDate", 
                p0, 
                p1);

            return result;
        }

    }
}
