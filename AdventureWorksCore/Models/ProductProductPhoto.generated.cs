using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("ProductProductPhoto", Schema="Production")]
    public partial class ProductProductPhoto
    {
        public ProductProductPhoto()
        {

        }

        ///<summary>Product identification number. Foreign key to Product.ProductID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ProductID", Order = 0)]
        public int ProductId { get; set; }

        ///<summary>Product photo identification number. Foreign key to ProductPhoto.ProductPhotoID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ProductPhotoID", Order = 1)]
        public int ProductPhotoId { get; set; }

        ///<summary>0 = Photo is not the principal image. 1 = Photo is the principal image.</summary>
        ///<remarks></remarks>
        [Column("Primary", Order = 2)]
        public bool Primary { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 3)]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

        public virtual ProductPhoto ProductPhoto { get; set; }

    }
}
