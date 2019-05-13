using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("OrderTracking", Schema="Sales")]
    public partial class OrderTracking
    {
        public OrderTracking()
        {

        }

        ///<summary>Primary key.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("OrderTrackingID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderTrackingId { get; set; }

        ///<summary>Sales order identification number.  Foreign key to SalesOrderHeader.SalesOrderID.</summary>
        ///<remarks></remarks>
        [Column("SalesOrderID", Order = 1)]
        public int SalesOrderId { get; set; }

        ///<summary>Shipment tracking number supplied by the shipper.</summary>
        ///<remarks></remarks>
        [Column("CarrierTrackingNumber", Order = 2)]
        [StringLength(25)]
        public string CarrierTrackingNumber { get; set; }

        ///<summary>Tracking delivery event for Order shipped to customer. Foreign key to TrackingEvent.TrackingEventID.</summary>
        ///<remarks></remarks>
        [Column("TrackingEventID", Order = 3)]
        public int TrackingEventId { get; set; }

        ///<summary>Details for a delivery tracking event.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("EventDetails", Order = 4)]
        [StringLength(2000)]
        public string EventDetails { get; set; }

        ///<summary>The date and time that a tracking event has occurred.</summary>
        ///<remarks></remarks>
        [Column("EventDateTime", Order = 5)]
        public DateTime EventDateTime { get; set; }

    }
}
