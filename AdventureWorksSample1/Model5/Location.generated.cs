using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.Location")]
    public partial class Location
    {
        public Location()
        {
            LocationId = 0;
            Name = null;
            CostRate = 0;
            Availability = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            ProductInventories = new HashSet<ProductInventory>();
            WorkOrderRoutings = new HashSet<WorkOrderRouting>();

        }

        ///<summary>Primary key for Location records.</summary>
        [Key]
        [Column("LocationID", Order = 0, TypeName = "smallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short LocationId { get; set; }

        ///<summary>Location description.</summary>
        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>Standard hourly cost of the manufacturing location.</summary>
        [Column("CostRate", Order = 2, TypeName = "smallmoney")]
        public decimal CostRate { get; set; }

        ///<summary>Work capacity (in hours) of the manufacturing location.</summary>
        [Column("Availability", Order = 3, TypeName = "decimal")]
        public decimal Availability { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }

    }
}
