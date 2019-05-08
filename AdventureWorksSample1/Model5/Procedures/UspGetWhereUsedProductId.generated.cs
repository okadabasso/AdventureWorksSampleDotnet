using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace Sample.Entities
{
    public partial class UspGetWhereUsedProductId
    {
        private readonly SampleDbContext context;
        public UspGetWhereUsedProductId()
        {
            context = new SampleDbContext();
        }
        public UspGetWhereUsedProductId(SampleDbContext context)
        {
            this.context = context;
        }

        public int Execute(
            int? startProductId, 
            DateTime? checkDate
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@StartProductID",  startProductId);
            var p1 = new SqlParameter("@CheckDate",  checkDate);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [dbo].[uspGetWhereUsedProductID] @StartProductID = @StartProductID, @CheckDate = @CheckDate",
                returnValue, p0, p1);

            return (int)returnValue.Value;
        }
        public IEnumerable<T> Query<T>(
            int? startProductId, 
            DateTime? checkDate        )
        {
            var p0 = new SqlParameter("@StartProductID",  startProductId);
            var p1 = new SqlParameter("@CheckDate",  checkDate);

            var result = context.Database.SqlQuery<T>(@"EXEC [dbo].[uspGetWhereUsedProductID] @StartProductID = @StartProductID, @CheckDate = @CheckDate"
                , p0, p1);

            return result;
        }

    }
}
