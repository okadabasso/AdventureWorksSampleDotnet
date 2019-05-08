using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Production.ProductReview")]
    public partial class ProductReview
    {
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

        ///<summary>Primary key for ProductReview records.</summary>
        [Key]
        [Column("ProductReviewID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductReviewId { get; set; }

        ///<summary>Product identification number. Foreign key to Product.ProductID.</summary>
        [Column("ProductID")]
        public int ProductId { get; set; }

        ///<summary>Name of the reviewer.</summary>
        [Required]
        [Column("ReviewerName", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string ReviewerName { get; set; }

        ///<summary>Date review was submitted.</summary>
        [Column("ReviewDate", Order = 3, TypeName = "datetime")]
        public DateTime ReviewDate { get; set; }

        ///<summary>Reviewer's e-mail address.</summary>
        [Required]
        [Column("EmailAddress", Order = 4, TypeName = "nvarchar")]
        [StringLength(50)]
        public string EmailAddress { get; set; }

        ///<summary>Product rating given by the reviewer. Scale is 1 to 5 with 5 as the highest rating.</summary>
        [Column("Rating", Order = 5, TypeName = "int")]
        public int Rating { get; set; }

        ///<summary>Reviewer's comments</summary>
        [Column("Comments", Order = 6, TypeName = "nvarchar")]
        [StringLength(3850)]
        public string Comments { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 7, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

    }
}
