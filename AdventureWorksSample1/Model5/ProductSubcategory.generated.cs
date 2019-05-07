using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.ProductSubcategory")]
    public partial class ProductSubcategory
    {
        public ProductSubcategory()
        {
            ProductSubcategoryID = 0;
            ProductCategoryID = 0;
            Name = null;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            Products = new HashSet<Product>();

        }

        [Key]
        [Column("ProductSubcategoryID", Order = 0, TypeName = "int")]
        public int ProductSubcategoryID { get; set; }

        public int ProductCategoryID { get; set; }

        [Required]
        [Column("Name", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("rowguid", Order = 3, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//Product ProductSubcategory
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }

    }
}
