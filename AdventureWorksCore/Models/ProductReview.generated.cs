using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("ProductReview", Schema="Production")]
    public partial class ProductReview
    {
        public ProductReview()
        {

        }

        ///<summary>Primary key for ProductReview records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ProductReviewID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductReviewId { get; set; }

        ///<summary>Product identification number. Foreign key to Product.ProductID.</summary>
        ///<remarks></remarks>
        [Column("ProductID")]
        public int ProductId { get; set; }

        ///<summary>Name of the reviewer.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("ReviewerName", Order = 2)]
        [StringLength(50)]
        public string ReviewerName { get; set; }

        ///<summary>Date review was submitted.</summary>
        ///<remarks></remarks>
        [Column("ReviewDate", Order = 3)]
        public DateTime ReviewDate { get; set; }

        ///<summary>Reviewer's e-mail address.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("EmailAddress", Order = 4)]
        [StringLength(50)]
        public string EmailAddress { get; set; }

        ///<summary>Product rating given by the reviewer. Scale is 1 to 5 with 5 as the highest rating.</summary>
        ///<remarks></remarks>
        [Column("Rating", Order = 5)]
        public int Rating { get; set; }

        ///<summary>Reviewer's comments</summary>
        ///<remarks></remarks>
        [Column("Comments", Order = 6)]
        [StringLength(3850)]
        public string Comments { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 7)]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

    }
}
