using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("TrackingEvent", Schema="Sales")]
    public partial class TrackingEvent
    {
        public TrackingEvent()
        {

        }

        ///<summary>Primary key.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("TrackingEventID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TrackingEventId { get; set; }

        ///<summary>Tracking event name.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("EventName", Order = 1)]
        [StringLength(255)]
        public string EventName { get; set; }

    }
}
