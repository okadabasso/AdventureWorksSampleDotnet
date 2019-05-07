using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.ProductModel")]
    public partial class ProductModel
    {
        public ProductModel()
        {
            ProductModelID = 0;
            Name = null;
            CatalogDescription = null;
            Instructions = null;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            Products = new HashSet<Product>();
            ProductModelIllustrations = new HashSet<ProductModelIllustration>();
            ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();

        }

        [Key]
        [Column("ProductModelID", Order = 0, TypeName = "int")]
        public int ProductModelID { get; set; }

        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("CatalogDescription", Order = 2, TypeName = "xml")]
        public string CatalogDescription { get; set; }

        [Column("Instructions", Order = 3, TypeName = "xml")]
        public string Instructions { get; set; }

        [Column("rowguid", Order = 4, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//Product ProductModel
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }

//ProductModelIllustration ProductModel
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; }

//ProductModelProductDescriptionCulture ProductModel
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }

    }
}
