using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace Sample.Entities
{
    public partial class UspAddOrderTrackingEvent
    {
        private readonly SampleDbContext context;
        public UspAddOrderTrackingEvent()
        {
            context = new SampleDbContext();
        }
        public UspAddOrderTrackingEvent(SampleDbContext context)
        {
            this.context = context;
        }

        public int Execute(
            int? salesOrderId, 
            int? trackingEventId, 
            string eventDetails
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@SalesOrderID",  salesOrderId);
            var p1 = new SqlParameter("@TrackingEventID",  trackingEventId);
            var p2 = new SqlParameter("@EventDetails",  eventDetails);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [dbo].[uspAddOrderTrackingEvent] @SalesOrderID = @SalesOrderID, @TrackingEventID = @TrackingEventID, @EventDetails = @EventDetails",
                returnValue, p0, p1, p2);

            return (int)returnValue.Value;
        }
        public IEnumerable<T> Query<T>(
            int? salesOrderId, 
            int? trackingEventId, 
            string eventDetails        )
        {
            var p0 = new SqlParameter("@SalesOrderID",  salesOrderId);
            var p1 = new SqlParameter("@TrackingEventID",  trackingEventId);
            var p2 = new SqlParameter("@EventDetails",  eventDetails);

            var result = context.Database.SqlQuery<T>(@"EXEC [dbo].[uspAddOrderTrackingEvent] @SalesOrderID = @SalesOrderID, @TrackingEventID = @TrackingEventID, @EventDetails = @EventDetails"
                , p0, p1, p2);

            return result;
        }

    }
}
