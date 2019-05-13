using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("Location", Schema="Production")]
    public partial class Location
    {
        public Location()
        {
            ProductInventories = new HashSet<ProductInventory>();
            WorkOrderRoutings = new HashSet<WorkOrderRouting>();

        }

        ///<summary>Primary key for Location records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("LocationID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short LocationId { get; set; }

        ///<summary>Location description.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Name", Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>Standard hourly cost of the manufacturing location.</summary>
        ///<remarks></remarks>
        [Column("CostRate", Order = 2)]
        public decimal CostRate { get; set; }

        ///<summary>Work capacity (in hours) of the manufacturing location.</summary>
        ///<remarks></remarks>
        [Column("Availability", Order = 3)]
        public decimal Availability { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 4)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }

    }
}
