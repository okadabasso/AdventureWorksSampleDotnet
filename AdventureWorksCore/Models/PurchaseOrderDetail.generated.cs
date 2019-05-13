using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("PurchaseOrderDetail", Schema="Purchasing")]
    public partial class PurchaseOrderDetail
    {
        public PurchaseOrderDetail()
        {

        }

        ///<summary>Primary key. Foreign key to PurchaseOrderHeader.PurchaseOrderID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("PurchaseOrderID", Order = 0)]
        public int PurchaseOrderId { get; set; }

        ///<summary>Primary key. One line number per purchased product.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("PurchaseOrderDetailID", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PurchaseOrderDetailId { get; set; }

        ///<summary>Date the product is expected to be received.</summary>
        ///<remarks></remarks>
        [Column("DueDate", Order = 2)]
        public DateTime DueDate { get; set; }

        ///<summary>Quantity ordered.</summary>
        ///<remarks></remarks>
        [Column("OrderQty", Order = 3)]
        public short OrderQty { get; set; }

        ///<summary>Product identification number. Foreign key to Product.ProductID.</summary>
        ///<remarks></remarks>
        [Column("ProductID")]
        public int ProductId { get; set; }

        ///<summary>Vendor's selling price of a single product.</summary>
        ///<remarks></remarks>
        [Column("UnitPrice", Order = 5)]
        public decimal UnitPrice { get; set; }

        ///<summary>Per product subtotal. Computed as OrderQty * UnitPrice.</summary>
        ///<remarks></remarks>
        [Column("LineTotal", Order = 6)]
        public decimal LineTotal { get; set; }

        ///<summary>Quantity actually received from the vendor.</summary>
        ///<remarks></remarks>
        [Column("ReceivedQty", Order = 7)]
        public decimal ReceivedQty { get; set; }

        ///<summary>Quantity rejected during inspection.</summary>
        ///<remarks></remarks>
        [Column("RejectedQty", Order = 8)]
        public decimal RejectedQty { get; set; }

        ///<summary>Quantity accepted into inventory. Computed as ReceivedQty - RejectedQty.</summary>
        ///<remarks></remarks>
        [Column("StockedQty", Order = 9)]
        public decimal StockedQty { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 10)]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

        public virtual PurchaseOrderHeader PurchaseOrderHeader { get; set; }

    }
}
