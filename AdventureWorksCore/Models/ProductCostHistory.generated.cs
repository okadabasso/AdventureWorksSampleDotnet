using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("ProductCostHistory", Schema="Production")]
    public partial class ProductCostHistory
    {
        public ProductCostHistory()
        {

        }

        ///<summary>Product identification number. Foreign key to Product.ProductID</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ProductID", Order = 0)]
        public int ProductId { get; set; }

        ///<summary>Product cost start date.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("StartDate", Order = 1)]
        public DateTime StartDate { get; set; }

        ///<summary>Product cost end date.</summary>
        ///<remarks></remarks>
        [Column("EndDate", Order = 2)]
        public DateTime? EndDate { get; set; }

        ///<summary>Standard cost of the product.</summary>
        ///<remarks></remarks>
        [Column("StandardCost", Order = 3)]
        public decimal StandardCost { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 4)]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

    }
}
