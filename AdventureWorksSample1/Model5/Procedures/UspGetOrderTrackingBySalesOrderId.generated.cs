using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace Sample.Entities
{
    public partial class UspGetOrderTrackingBySalesOrderId
    {
        private readonly SampleDbContext context;
        public UspGetOrderTrackingBySalesOrderId()
        {
            context = new SampleDbContext();
        }
        public UspGetOrderTrackingBySalesOrderId(SampleDbContext context)
        {
            this.context = context;
        }

        public int Execute(
            int? salesOrderId
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@SalesOrderID",  salesOrderId);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [dbo].[uspGetOrderTrackingBySalesOrderID] @SalesOrderID = @SalesOrderID",
                returnValue, p0);

            return (int)returnValue.Value;
        }
        public IEnumerable<T> Query<T>(
            int? salesOrderId        )
        {
            var p0 = new SqlParameter("@SalesOrderID",  salesOrderId);

            var result = context.Database.SqlQuery<T>(@"EXEC [dbo].[uspGetOrderTrackingBySalesOrderID] @SalesOrderID = @SalesOrderID"
                , p0);

            return result;
        }

    }
}
