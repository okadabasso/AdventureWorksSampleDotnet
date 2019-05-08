using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Production.ProductPhoto")]
    public partial class ProductPhoto
    {
        public ProductPhoto()
        {
            ProductPhotoId = 0;
            ThumbNailPhoto = null;
            ThumbnailPhotoFileName = null;
            LargePhoto = null;
            LargePhotoFileName = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            ProductProductPhotos = new HashSet<ProductProductPhoto>();

        }

        ///<summary>Primary key for ProductPhoto records.</summary>
        [Key]
        [Column("ProductPhotoID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductPhotoId { get; set; }

        ///<summary>Small image of the product.</summary>
        [Column("ThumbNailPhoto", Order = 1, TypeName = "varbinary")]
        public byte[] ThumbNailPhoto { get; set; }

        ///<summary>Small image file name.</summary>
        [Column("ThumbnailPhotoFileName", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string ThumbnailPhotoFileName { get; set; }

        ///<summary>Large image of the product.</summary>
        [Column("LargePhoto", Order = 3, TypeName = "varbinary")]
        public byte[] LargePhoto { get; set; }

        ///<summary>Large image file name.</summary>
        [Column("LargePhotoFileName", Order = 4, TypeName = "nvarchar")]
        [StringLength(50)]
        public string LargePhotoFileName { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductProductPhoto> ProductProductPhotos { get; set; }

    }
}
