using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.ProductProductPhoto")]
    public partial class ProductProductPhoto
    {
        [Key]
        [Column("ProductID", Order = 1, TypeName = "int")]
        public int ProductId { get; set; }
        [Key]
        [Column("ProductPhotoID", Order = 2, TypeName = "int")]
        public int ProductPhotoId { get; set; }
        [Column("Primary", Order = 3, TypeName = "bit")]
        public bool Primary { get; set; }
        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public ProductProductPhoto()
        {
            ProductId = 0;
            ProductPhotoId = 0;
            Primary = false;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
