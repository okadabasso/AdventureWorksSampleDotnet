using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.ScrapReason")]
    public partial class ScrapReason
    {
        public ScrapReason()
        {
            ScrapReasonId = 0;
            Name = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            WorkOrders = new HashSet<WorkOrder>();

        }

        ///<summary>Primary key for ScrapReason records.</summary>
        [Key]
        [Column("ScrapReasonID", Order = 0, TypeName = "smallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short ScrapReasonId { get; set; }

        ///<summary>Failure description.</summary>
        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 2, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }

    }
}
