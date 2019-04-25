using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.TrackingEvent")]
    public partial class TrackingEvent
    {
        [Key]
        [Column("TrackingEventID", Order = 1, TypeName = "int")]
        public int TrackingEventId { get; set; }
        [Column("EventName", Order = 2, TypeName = "nvarchar")]
        [StringLength(255)]
        public string EventName { get; set; }
        public TrackingEvent()
        {
            TrackingEventId = 0;
            EventName = null;
        }
    }
}
