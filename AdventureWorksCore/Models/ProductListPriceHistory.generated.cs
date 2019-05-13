using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("ProductListPriceHistory", Schema="Production")]
    public partial class ProductListPriceHistory
    {
        public ProductListPriceHistory()
        {

        }

        ///<summary>Product identification number. Foreign key to Product.ProductID</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ProductID", Order = 0)]
        public int ProductId { get; set; }

        ///<summary>List price start date.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("StartDate", Order = 1)]
        public DateTime StartDate { get; set; }

        ///<summary>List price end date</summary>
        ///<remarks></remarks>
        [Column("EndDate", Order = 2)]
        public DateTime? EndDate { get; set; }

        ///<summary>Product list price.</summary>
        ///<remarks></remarks>
        [Column("ListPrice", Order = 3)]
        public decimal ListPrice { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 4)]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

    }
}
