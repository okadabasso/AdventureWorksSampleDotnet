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
            TrackingEventId = 0;
            EventName = null;

        }

        ///<summary>Primary key.</summary>
        [Key]
        [Column("TrackingEventID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TrackingEventId { get; set; }

        ///<summary>Tracking event name.</summary>
        [Required]
        [Column("EventName", Order = 1, TypeName = "nvarchar")]
        [StringLength(255)]
        public string EventName { get; set; }

    }
}
