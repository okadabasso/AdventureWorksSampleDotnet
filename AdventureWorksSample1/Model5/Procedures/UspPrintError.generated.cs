using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace Sample.Entities
{
    public partial class UspPrintError
    {
        private readonly SampleDbContext context;
        public UspPrintError()
        {
            context = new SampleDbContext();
        }
        public UspPrintError(SampleDbContext context)
        {
            this.context = context;
        }

        public int Execute(

        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [dbo].[uspPrintError]",
                returnValue);

            return (int)returnValue.Value;
        }
        public IEnumerable<T> Query<T>(
        )
        {

            var result = context.Database.SqlQuery<T>(@"EXEC [dbo].[uspPrintError]"
                );

            return result;
        }

    }
}
