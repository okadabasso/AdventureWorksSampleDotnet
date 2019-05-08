using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace Sample.Entities
{
    public partial class UfngetaccountingenddateNative
    {
        private readonly SampleDbContext context;
        public UfngetaccountingenddateNative()
        {
            context = new SampleDbContext();
        }
        public UfngetaccountingenddateNative(SampleDbContext context)
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
