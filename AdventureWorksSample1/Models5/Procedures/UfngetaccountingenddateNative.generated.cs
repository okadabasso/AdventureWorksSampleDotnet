using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace AdventureWorks1.Models5
{
    public partial class UfnGetAccountingEndDateNative
    {
        private readonly  SampleDbContext context;
        public UfnGetAccountingEndDateNative()
        {
            context = new  SampleDbContext();
        }
        public UfnGetAccountingEndDateNative( SampleDbContext context)
        {
            this.context = context;
        }

        public DateTime? Execute(

        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.Output};

            var affected = context.Database.ExecuteSqlCommand(@"SELECT @return_value = [dbo].[ufnGetAccountingEndDate_native]()",
                returnValue);

            return (DateTime?)returnValue.Value;
        }
    }
}
