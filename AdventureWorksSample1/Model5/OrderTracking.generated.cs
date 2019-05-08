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
            OrderTrackingId = 0;
            SalesOrderId = 0;
            CarrierTrackingNumber = null;
            TrackingEventId = 0;
            EventDetails = null;
            EventDateTime = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Primary key.</summary>
        [Key]
        [Column("OrderTrackingID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderTrackingId { get; set; }

        ///<summary>Sales order identification number.  Foreign key to SalesOrderHeader.SalesOrderID.</summary>
        [Column("SalesOrderID", Order = 1, TypeName = "int")]
        public int SalesOrderId { get; set; }

        ///<summary>Shipment tracking number supplied by the shipper.</summary>
        [Column("CarrierTrackingNumber", Order = 2, TypeName = "nvarchar")]
        [StringLength(25)]
        public string CarrierTrackingNumber { get; set; }

        ///<summary>Tracking delivery event for Order shipped to customer. Foreign key to TrackingEvent.TrackingEventID.</summary>
        [Column("TrackingEventID", Order = 3, TypeName = "int")]
        public int TrackingEventId { get; set; }

        ///<summary>Details for a delivery tracking event.</summary>
        [Required]
        [Column("EventDetails", Order = 4, TypeName = "nvarchar")]
        [StringLength(2000)]
        public string EventDetails { get; set; }

        ///<summary>The date and time that a tracking event has occurred.</summary>
        [Column("EventDateTime", Order = 5, TypeName = "datetime2")]
        public DateTime EventDateTime { get; set; }

    }
}
