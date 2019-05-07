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
        public ProductProductPhoto()
        {
            ProductID = 0;
            ProductPhotoID = 0;
            Primary = false;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("ProductID", Order = 0, TypeName = "int")]
        public int ProductID { get; set; }

        [Key]
        [Column("ProductPhotoID", Order = 1, TypeName = "int")]
        public int ProductPhotoID { get; set; }

        [Column("Primary", Order = 2, TypeName = "bit")]
        public bool Primary { get; set; }

        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

        public virtual ProductPhoto ProductPhoto { get; set; }

    }
}
