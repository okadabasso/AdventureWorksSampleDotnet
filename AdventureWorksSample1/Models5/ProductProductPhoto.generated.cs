using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Production.ProductProductPhoto")]
    public partial class ProductProductPhoto
    {
        public ProductProductPhoto()
        {
            ProductId = 0;
            ProductPhotoId = 0;
            Primary = false;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Product identification number. Foreign key to Product.ProductID.</summary>
        [Key]
        [Column("ProductID", Order = 0, TypeName = "int")]
        public int ProductId { get; set; }

        ///<summary>Product photo identification number. Foreign key to ProductPhoto.ProductPhotoID.</summary>
        [Key]
        [Column("ProductPhotoID", Order = 1, TypeName = "int")]
        public int ProductPhotoId { get; set; }

        ///<summary>0 = Photo is not the principal image. 1 = Photo is the principal image.</summary>
        [Column("Primary", Order = 2, TypeName = "bit")]
        public bool Primary { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

        public virtual ProductPhoto ProductPhoto { get; set; }

    }
}
