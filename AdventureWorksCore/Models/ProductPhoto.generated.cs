using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("ProductPhoto", Schema="Production")]
    public partial class ProductPhoto
    {
        public ProductPhoto()
        {
            ProductProductPhotos = new HashSet<ProductProductPhoto>();

        }

        ///<summary>Primary key for ProductPhoto records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ProductPhotoID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductPhotoId { get; set; }

        ///<summary>Small image of the product.</summary>
        ///<remarks></remarks>
        [Column("ThumbNailPhoto", Order = 1)]
        public byte[] ThumbNailPhoto { get; set; }

        ///<summary>Small image file name.</summary>
        ///<remarks></remarks>
        [Column("ThumbnailPhotoFileName", Order = 2)]
        [StringLength(50)]
        public string ThumbnailPhotoFileName { get; set; }

        ///<summary>Large image of the product.</summary>
        ///<remarks></remarks>
        [Column("LargePhoto", Order = 3)]
        public byte[] LargePhoto { get; set; }

        ///<summary>Large image file name.</summary>
        ///<remarks></remarks>
        [Column("LargePhotoFileName", Order = 4)]
        [StringLength(50)]
        public string LargePhotoFileName { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 5)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductProductPhoto> ProductProductPhotos { get; set; }

    }
}
