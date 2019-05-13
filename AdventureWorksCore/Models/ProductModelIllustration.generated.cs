using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("ProductModelIllustration", Schema="Production")]
    public partial class ProductModelIllustration
    {
        public ProductModelIllustration()
        {

        }

        ///<summary>Primary key. Foreign key to ProductModel.ProductModelID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ProductModelID", Order = 0)]
        public int ProductModelId { get; set; }

        ///<summary>Primary key. Foreign key to Illustration.IllustrationID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("IllustrationID", Order = 1)]
        public int IllustrationId { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 2)]
        public DateTime ModifiedDate { get; set; }

        public virtual Illustration Illustration { get; set; }

        public virtual ProductModel ProductModel { get; set; }

    }
}
