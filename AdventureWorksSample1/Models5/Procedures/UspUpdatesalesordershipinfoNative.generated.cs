using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace AdventureWorks1.Models5
{
    public partial class UspUpdateSalesOrderShipInfoNative
    {
        private readonly SampleDbContext  context;
        public UspUpdateSalesOrderShipInfoNative()
        {
            context = new SampleDbContext ();
        }
        public UspUpdateSalesOrderShipInfoNative(SampleDbContext  context)
        {
            this.context = context;
        }

        ///<summary>execute command Sales.usp_UpdateSalesOrderShipInfo_native</summary>
        public int Execute(
            int? salesOrderId, 
            DateTime? shipDate, 
            string comment, 
            byte? status, 
            decimal? taxRate, 
            decimal? freight, 
            string carrierTrackingNumber
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@SalesOrderID",  salesOrderId);
            var p1 = new SqlParameter("@ShipDate",  shipDate);
            var p2 = new SqlParameter("@Comment",  comment);
            var p3 = new SqlParameter("@Status",  status);
            var p4 = new SqlParameter("@TaxRate",  taxRate);
            var p5 = new SqlParameter("@Freight",  freight);
            var p6 = new SqlParameter("@CarrierTrackingNumber",  carrierTrackingNumber);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [Sales].[usp_UpdateSalesOrderShipInfo_native]
@SalesOrderID = @SalesOrderID,
@ShipDate = @ShipDate,
@Comment = @Comment,
@Status = @Status,
@TaxRate = @TaxRate,
@Freight = @Freight,
@CarrierTrackingNumber = @CarrierTrackingNumber",
                returnValue, 
                p0, 
                p1, 
                p2, 
                p3, 
                p4, 
                p5, 
                p6);

            return (int)returnValue.Value;
        }
        ///<summary>execute query Sales.usp_UpdateSalesOrderShipInfo_native</summary>
        public IEnumerable<T> Query<T>(
            int? salesOrderId, 
            DateTime? shipDate, 
            string comment, 
            byte? status, 
            decimal? taxRate, 
            decimal? freight, 
            string carrierTrackingNumber
        )
        {
            var p0 = new SqlParameter("@SalesOrderID",  salesOrderId);
            var p1 = new SqlParameter("@ShipDate",  shipDate);
            var p2 = new SqlParameter("@Comment",  comment);
            var p3 = new SqlParameter("@Status",  status);
            var p4 = new SqlParameter("@TaxRate",  taxRate);
            var p5 = new SqlParameter("@Freight",  freight);
            var p6 = new SqlParameter("@CarrierTrackingNumber",  carrierTrackingNumber);

            var result = context.Database.SqlQuery<T>(@"EXEC [Sales].[usp_UpdateSalesOrderShipInfo_native]
@SalesOrderID = @SalesOrderID,
@ShipDate = @ShipDate,
@Comment = @Comment,
@Status = @Status,
@TaxRate = @TaxRate,
@Freight = @Freight,
@CarrierTrackingNumber = @CarrierTrackingNumber", 
                p0, 
                p1, 
                p2, 
                p3, 
                p4, 
                p5, 
                p6);

            return result;
        }

    }
}
