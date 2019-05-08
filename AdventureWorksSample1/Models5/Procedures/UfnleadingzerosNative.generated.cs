using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace AdventureWorks1.Models5
{
    public partial class UfnleadingzerosNative
    {
        private readonly  SampleDbContext context;
        public UfnleadingzerosNative()
        {
            context = new  SampleDbContext();
        }
        public UfnleadingzerosNative( SampleDbContext context)
        {
            this.context = context;
        }

        public string Execute(
            int? value
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.Output};
            returnValue.Size = 8;
            var p0 = new SqlParameter("@Value",  value);

            var affected = context.Database.ExecuteSqlCommand(@"SELECT @return_value = [dbo].[ufnLeadingZeros_native](
                @Value)",
                returnValue, 
                p0);

            return (string)returnValue.Value;
        }
    }
}
