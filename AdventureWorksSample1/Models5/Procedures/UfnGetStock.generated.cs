using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace AdventureWorks1.Models5
{
    public partial class UfnGetStock
    {
        private readonly  SampleDbContext context;
        public UfnGetStock()
        {
            context = new  SampleDbContext();
        }
        public UfnGetStock( SampleDbContext context)
        {
            this.context = context;
        }

        public int? Execute(
            int? productId
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.Output};
            var p0 = new SqlParameter("@ProductID",  productId);

            var affected = context.Database.ExecuteSqlCommand(@"SELECT @return_value = [dbo].[ufnGetStock](
                @ProductID)",
                returnValue, 
                p0);

            return (int?)returnValue.Value;
        }
    }
}
