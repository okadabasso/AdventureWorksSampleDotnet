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
        [Key]
        [Column("ProductSubcategoryID", Order = 1, TypeName = "int")]
        public int ProductSubcategoryId { get; set; }
        [Column("ProductCategoryID", Order = 2, TypeName = "int")]
        public int ProductCategoryId { get; set; }
        [Column("Name", Order = 3, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("rowguid", Order = 4, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }
        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public ProductSubcategory()
        {
            ProductSubcategoryId = 0;
            ProductCategoryId = 0;
            Name = null;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
