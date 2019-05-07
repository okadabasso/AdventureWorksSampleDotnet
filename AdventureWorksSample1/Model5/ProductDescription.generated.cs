using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.ProductDescription")]
    public partial class ProductDescription
    {
        public ProductDescription()
        {
            ProductDescriptionID = 0;
            Description = null;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();

        }

        [Key]
        [Column("ProductDescriptionID", Order = 0, TypeName = "int")]
        public int ProductDescriptionID { get; set; }

        [Required]
        [Column("Description", Order = 1, TypeName = "nvarchar")]
        [StringLength(400)]
        public string Description { get; set; }

        [Column("rowguid", Order = 2, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//ProductModelProductDescriptionCulture ProductDescription
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }

    }
}
