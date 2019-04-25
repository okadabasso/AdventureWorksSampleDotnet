using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.OrderTracking")]
    public partial class OrderTracking
    {
        [Key]
        [Column("OrderTrackingID", Order = 1, TypeName = "int")]
        public int OrderTrackingId { get; set; }
        [Column("SalesOrderID", Order = 2, TypeName = "int")]
        public int SalesOrderId { get; set; }
        [Column("CarrierTrackingNumber", Order = 3, TypeName = "nvarchar")]
        [StringLength(25)]
        public string CarrierTrackingNumber { get; set; }
        [Column("TrackingEventID", Order = 4, TypeName = "int")]
        public int TrackingEventId { get; set; }
        [Column("EventDetails", Order = 5, TypeName = "nvarchar")]
        [StringLength(2000)]
        public string EventDetails { get; set; }
        [Column("EventDateTime", Order = 6, TypeName = "datetime2")]
        public DateTime EventDateTime { get; set; }
        public OrderTracking()
        {
            OrderTrackingId = 0;
            SalesOrderId = 0;
            CarrierTrackingNumber = null;
            TrackingEventId = 0;
            EventDetails = null;
            EventDateTime = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
