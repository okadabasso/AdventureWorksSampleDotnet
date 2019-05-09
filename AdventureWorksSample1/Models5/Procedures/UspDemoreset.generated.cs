using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace AdventureWorks1.Models5
{
    public partial class UspDemoReset
    {
        private readonly SampleDbContext  context;
        public UspDemoReset()
        {
            context = new SampleDbContext ();
        }
        public UspDemoReset(SampleDbContext  context)
        {
            this.context = context;
        }

        ///<summary>execute command Demo.usp_DemoReset</summary>
        public int Execute(

        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [Demo].[usp_DemoReset]",
                returnValue);

            return (int)returnValue.Value;
        }
        ///<summary>execute query Demo.usp_DemoReset</summary>
        public IEnumerable<T> Query<T>(

        )
        {

            var result = context.Database.SqlQuery<T>(@"EXEC [Demo].[usp_DemoReset]");

            return result;
        }

    }
}
