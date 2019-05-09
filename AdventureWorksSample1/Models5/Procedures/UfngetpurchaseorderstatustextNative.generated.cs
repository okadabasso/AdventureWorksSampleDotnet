using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace AdventureWorks1.Models5
{
    public partial class UfnGetPurchaseOrderStatusTextNative
    {
        private readonly  SampleDbContext context;
        public UfnGetPurchaseOrderStatusTextNative()
        {
            context = new  SampleDbContext();
        }
        public UfnGetPurchaseOrderStatusTextNative( SampleDbContext context)
        {
            this.context = context;
        }

        public string Execute(
            byte? status
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.Output};
            returnValue.Size = 15;
            var p0 = new SqlParameter("@Status",  status);

            var affected = context.Database.ExecuteSqlCommand(@"SELECT @return_value = [dbo].[ufnGetPurchaseOrderStatusText_native](
                @Status)",
                returnValue, 
                p0);

            return (string)returnValue.Value;
        }
    }
}
