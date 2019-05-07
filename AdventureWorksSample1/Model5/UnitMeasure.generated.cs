using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.UnitMeasure")]
    public partial class UnitMeasure
    {
        public UnitMeasure()
        {
            UnitMeasureCode = null;
            Name = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            BillOfMaterials = new HashSet<BillOfMaterials>();
            Products = new HashSet<Product>();
            Products1 = new HashSet<Product>();
            ProductVendors = new HashSet<ProductVendor>();

        }

        [Key]
        [Required]
        [Column("UnitMeasureCode", Order = 0, TypeName = "nchar")]
        [StringLength(3)]
        public string UnitMeasureCode { get; set; }

        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("ModifiedDate", Order = 2, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//BillOfMaterials UnitMeasure
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillOfMaterials> BillOfMaterials { get; set; }

//Product UnitMeasure
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }

//Product UnitMeasure
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products1 { get; set; }

//ProductVendor UnitMeasure
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }

    }
}
