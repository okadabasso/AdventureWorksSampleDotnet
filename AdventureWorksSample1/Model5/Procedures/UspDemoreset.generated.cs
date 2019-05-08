using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace Sample.Entities
{
    public partial class UspDemoreset
    {
        private readonly SampleDbContext context;
        public UspDemoreset()
        {
            context = new SampleDbContext();
        }
        public UspDemoreset(SampleDbContext context)
        {
            this.context = context;
        }

        public int Execute(

        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [Demo].[usp_DemoReset]",
                returnValue);

            return (int)returnValue.Value;
        }
        public IEnumerable<T> Query<T>(
        )
        {

            var result = context.Database.SqlQuery<T>(@"EXEC [Demo].[usp_DemoReset]"
                );

            return result;
        }

    }
}
