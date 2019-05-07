using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.ProductReview")]
    public partial class ProductReview
    {
        public ProductReview()
        {
            ProductReviewID = 0;
            ProductID = 0;
            ReviewerName = null;
            ReviewDate = DateTime.Parse("0001/01/01 0:00:00");
            EmailAddress = null;
            Rating = 0;
            Comments = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("ProductReviewID", Order = 0, TypeName = "int")]
        public int ProductReviewID { get; set; }

        public int ProductID { get; set; }

        [Required]
        [Column("ReviewerName", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string ReviewerName { get; set; }

        [Column("ReviewDate", Order = 3, TypeName = "datetime")]
        public DateTime ReviewDate { get; set; }

        [Required]
        [Column("EmailAddress", Order = 4, TypeName = "nvarchar")]
        [StringLength(50)]
        public string EmailAddress { get; set; }

        [Column("Rating", Order = 5, TypeName = "int")]
        public int Rating { get; set; }

        [Column("Comments", Order = 6, TypeName = "nvarchar")]
        [StringLength(3850)]
        public string Comments { get; set; }

        [Column("ModifiedDate", Order = 7, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

    }
}
