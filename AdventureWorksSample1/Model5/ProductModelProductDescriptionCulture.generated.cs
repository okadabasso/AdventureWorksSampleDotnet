using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.ProductModelProductDescriptionCulture")]
    public partial class ProductModelProductDescriptionCulture
    {
        [Key]
        [Column("ProductModelID", Order = 1, TypeName = "int")]
        public int ProductModelId { get; set; }
        [Key]
        [Column("ProductDescriptionID", Order = 2, TypeName = "int")]
        public int ProductDescriptionId { get; set; }
        [Key]
        [Column("CultureID", Order = 3, TypeName = "nchar")]
        [StringLength(6)]
        public string CultureId { get; set; }
        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public ProductModelProductDescriptionCulture()
        {
            ProductModelId = 0;
            ProductDescriptionId = 0;
            CultureId = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
