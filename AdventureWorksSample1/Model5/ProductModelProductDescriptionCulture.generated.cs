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
        public ProductModelProductDescriptionCulture()
        {
            ProductModelID = 0;
            ProductDescriptionID = 0;
            CultureID = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("ProductModelID", Order = 0, TypeName = "int")]
        public int ProductModelID { get; set; }

        [Key]
        [Column("ProductDescriptionID", Order = 1, TypeName = "int")]
        public int ProductDescriptionID { get; set; }

        [Key]
        [Required]
        [Column("CultureID", Order = 2, TypeName = "nchar")]
        [StringLength(6)]
        public string CultureID { get; set; }

        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Culture Culture { get; set; }

        public virtual ProductDescription ProductDescription { get; set; }

        public virtual ProductModel ProductModel { get; set; }

    }
}
