using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace AdventureWorks1.Models5
{
    public partial class UfnGetProductListPrice
    {
        private readonly  SampleDbContext context;
        public UfnGetProductListPrice()
        {
            context = new  SampleDbContext();
        }
        public UfnGetProductListPrice( SampleDbContext context)
        {
            this.context = context;
        }

        public decimal? Execute(
            int? productId, 
            DateTime? orderDate
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.Output};
            var p0 = new SqlParameter("@ProductID",  productId);
            var p1 = new SqlParameter("@OrderDate",  orderDate);

            var affected = context.Database.ExecuteSqlCommand(@"SELECT @return_value = [dbo].[ufnGetProductListPrice](
                @ProductID,
                @OrderDate)",
                returnValue, 
                p0, 
                p1);

            return (decimal?)returnValue.Value;
        }
    }
}
