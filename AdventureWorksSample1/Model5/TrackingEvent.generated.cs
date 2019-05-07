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
        public TrackingEvent()
        {
            TrackingEventID = 0;
            EventName = null;


        }

        [Key]
        [Column("TrackingEventID", Order = 0, TypeName = "int")]
        public int TrackingEventID { get; set; }

        [Required]
        [Column("EventName", Order = 1, TypeName = "nvarchar")]
        [StringLength(255)]
        public string EventName { get; set; }

    }
}
