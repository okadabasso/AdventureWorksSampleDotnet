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
            LocationID = 0;
            Name = null;
            CostRate = 0;
            Availability = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            ProductInventories = new HashSet<ProductInventory>();
            WorkOrderRoutings = new HashSet<WorkOrderRouting>();

        }

        [Key]
        [Column("LocationID", Order = 0, TypeName = "smallint")]
        public short LocationID { get; set; }

        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("CostRate", Order = 2, TypeName = "smallmoney")]
        public decimal CostRate { get; set; }

        [Column("Availability", Order = 3, TypeName = "decimal")]
        public decimal Availability { get; set; }

        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//ProductInventory Location
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }

//WorkOrderRouting Location
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }

    }
}
