using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.ProductCategory")]
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            ProductCategoryID = 0;
            Name = null;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            ProductSubcategories = new HashSet<ProductSubcategory>();

        }

        [Key]
        [Column("ProductCategoryID", Order = 0, TypeName = "int")]
        public int ProductCategoryID { get; set; }

        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("rowguid", Order = 2, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//ProductSubcategory ProductCategory
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSubcategory> ProductSubcategories { get; set; }

    }
}
