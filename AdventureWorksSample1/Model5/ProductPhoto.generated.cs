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
        [Key]
        [Column("ProductPhotoID", Order = 1, TypeName = "int")]
        public int ProductPhotoId { get; set; }
        [Column("ThumbNailPhoto", Order = 2, TypeName = "varbinary")]
        public byte[] ThumbNailPhoto { get; set; }
        [Column("ThumbnailPhotoFileName", Order = 3, TypeName = "nvarchar")]
        [StringLength(50)]
        public string ThumbnailPhotoFileName { get; set; }
        [Column("LargePhoto", Order = 4, TypeName = "varbinary")]
        public byte[] LargePhoto { get; set; }
        [Column("LargePhotoFileName", Order = 5, TypeName = "nvarchar")]
        [StringLength(50)]
        public string LargePhotoFileName { get; set; }
        [Column("ModifiedDate", Order = 6, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public ProductPhoto()
        {
            ProductPhotoId = 0;
            ThumbNailPhoto = null;
            ThumbnailPhotoFileName = null;
            LargePhoto = null;
            LargePhotoFileName = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
