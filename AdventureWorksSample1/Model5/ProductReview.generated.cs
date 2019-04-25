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
        [Key]
        [Column("ProductReviewID", Order = 1, TypeName = "int")]
        public int ProductReviewId { get; set; }
        [Column("ProductID", Order = 2, TypeName = "int")]
        public int ProductId { get; set; }
        [Column("ReviewerName", Order = 3, TypeName = "nvarchar")]
        [StringLength(50)]
        public string ReviewerName { get; set; }
        [Column("ReviewDate", Order = 4, TypeName = "datetime")]
        public DateTime ReviewDate { get; set; }
        [Column("EmailAddress", Order = 5, TypeName = "nvarchar")]
        [StringLength(50)]
        public string EmailAddress { get; set; }
        [Column("Rating", Order = 6, TypeName = "int")]
        public int Rating { get; set; }
        [Column("Comments", Order = 7, TypeName = "nvarchar")]
        [StringLength(3850)]
        public string Comments { get; set; }
        [Column("ModifiedDate", Order = 8, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public ProductReview()
        {
            ProductReviewId = 0;
            ProductId = 0;
            ReviewerName = null;
            ReviewDate = DateTime.Parse("0001/01/01 0:00:00");
            EmailAddress = null;
            Rating = 0;
            Comments = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
