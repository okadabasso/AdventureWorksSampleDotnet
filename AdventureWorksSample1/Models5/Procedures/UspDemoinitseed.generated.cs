using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace AdventureWorks1.Models5
{
    public partial class UspDemoInitSeed
    {
        private readonly SampleDbContext  context;
        public UspDemoInitSeed()
        {
            context = new SampleDbContext ();
        }
        public UspDemoInitSeed(SampleDbContext  context)
        {
            this.context = context;
        }

        ///<summary>execute command Demo.usp_DemoInitSeed</summary>
        public int Execute(
            int? itemsPerOrder
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@items_per_order",  itemsPerOrder);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [Demo].[usp_DemoInitSeed]
@items_per_order = @items_per_order",
                returnValue, 
                p0);

            return (int)returnValue.Value;
        }
        ///<summary>execute query Demo.usp_DemoInitSeed</summary>
        public IEnumerable<T> Query<T>(
            int? itemsPerOrder
        )
        {
            var p0 = new SqlParameter("@items_per_order",  itemsPerOrder);

            var result = context.Database.SqlQuery<T>(@"EXEC [Demo].[usp_DemoInitSeed]
@items_per_order = @items_per_order", 
                p0);

            return result;
        }

    }
}
