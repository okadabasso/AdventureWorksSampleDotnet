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
        public OrderTracking()
        {
            OrderTrackingID = 0;
            SalesOrderID = 0;
            CarrierTrackingNumber = null;
            TrackingEventID = 0;
            EventDetails = null;
            EventDateTime = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("OrderTrackingID", Order = 0, TypeName = "int")]
        public int OrderTrackingID { get; set; }

        [Column("SalesOrderID", Order = 1, TypeName = "int")]
        public int SalesOrderID { get; set; }

        [Column("CarrierTrackingNumber", Order = 2, TypeName = "nvarchar")]
        [StringLength(25)]
        public string CarrierTrackingNumber { get; set; }

        [Column("TrackingEventID", Order = 3, TypeName = "int")]
        public int TrackingEventID { get; set; }

        [Required]
        [Column("EventDetails", Order = 4, TypeName = "nvarchar")]
        [StringLength(2000)]
        public string EventDetails { get; set; }

        [Column("EventDateTime", Order = 5, TypeName = "datetime2")]
        public DateTime EventDateTime { get; set; }

    }
}
