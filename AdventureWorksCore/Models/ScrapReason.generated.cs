using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("ScrapReason", Schema="Production")]
    public partial class ScrapReason
    {
        public ScrapReason()
        {
            WorkOrders = new HashSet<WorkOrder>();

        }

        ///<summary>Primary key for ScrapReason records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ScrapReasonID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short ScrapReasonId { get; set; }

        ///<summary>Failure description.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Name", Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 2)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }

    }
}
