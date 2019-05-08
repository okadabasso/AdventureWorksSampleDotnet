using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace AdventureWorks1.Models5
{
    public partial class UspGetOrderTrackingByTrackingNumber
    {
        private readonly SampleDbContext  context;
        public UspGetOrderTrackingByTrackingNumber()
        {
            context = new SampleDbContext ();
        }
        public UspGetOrderTrackingByTrackingNumber(SampleDbContext  context)
        {
            this.context = context;
        }

        ///<summary>execute command dbo.uspGetOrderTrackingByTrackingNumber</summary>
        public int Execute(
            string carrierTrackingNumber
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@CarrierTrackingNumber",  carrierTrackingNumber);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [dbo].[uspGetOrderTrackingByTrackingNumber]
@CarrierTrackingNumber = @CarrierTrackingNumber",
                returnValue, 
                p0);

            return (int)returnValue.Value;
        }
        ///<summary>execute query dbo.uspGetOrderTrackingByTrackingNumber</summary>
        public IEnumerable<T> Query<T>(
            string carrierTrackingNumber
        )
        {
            var p0 = new SqlParameter("@CarrierTrackingNumber",  carrierTrackingNumber);

            var result = context.Database.SqlQuery<T>(@"EXEC [dbo].[uspGetOrderTrackingByTrackingNumber]
@CarrierTrackingNumber = @CarrierTrackingNumber", 
                p0);

            return result;
        }

    }
}
