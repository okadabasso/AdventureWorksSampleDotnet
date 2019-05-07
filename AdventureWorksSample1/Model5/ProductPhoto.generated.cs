using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.ProductPhoto")]
    public partial class ProductPhoto
    {
        public ProductPhoto()
        {
            ProductPhotoID = 0;
            ThumbNailPhoto = null;
            ThumbnailPhotoFileName = null;
            LargePhoto = null;
            LargePhotoFileName = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            ProductProductPhotos = new HashSet<ProductProductPhoto>();

        }

        [Key]
        [Column("ProductPhotoID", Order = 0, TypeName = "int")]
        public int ProductPhotoID { get; set; }

        [Column("ThumbNailPhoto", Order = 1, TypeName = "varbinary")]
        public byte[] ThumbNailPhoto { get; set; }

        [Column("ThumbnailPhotoFileName", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string ThumbnailPhotoFileName { get; set; }

        [Column("LargePhoto", Order = 3, TypeName = "varbinary")]
        public byte[] LargePhoto { get; set; }

        [Column("LargePhotoFileName", Order = 4, TypeName = "nvarchar")]
        [StringLength(50)]
        public string LargePhotoFileName { get; set; }

        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//ProductProductPhoto ProductPhoto
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductProductPhoto> ProductProductPhotos { get; set; }

    }
}
