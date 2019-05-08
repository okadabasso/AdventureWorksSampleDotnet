using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Purchasing.PurchaseOrderDetail")]
    public partial class PurchaseOrderDetail
    {
        public PurchaseOrderDetail()
        {
            PurchaseOrderId = 0;
            PurchaseOrderDetailId = 0;
            DueDate = DateTime.Parse("0001/01/01 0:00:00");
            OrderQty = 0;
            ProductId = 0;
            UnitPrice = 0;
            LineTotal = 0;
            ReceivedQty = 0;
            RejectedQty = 0;
            StockedQty = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Primary key. Foreign key to PurchaseOrderHeader.PurchaseOrderID.</summary>
        [Key]
        [Column("PurchaseOrderID", Order = 0, TypeName = "int")]
        public int PurchaseOrderId { get; set; }

        ///<summary>Primary key. One line number per purchased product.</summary>
        [Key]
        [Column("PurchaseOrderDetailID", Order = 1, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PurchaseOrderDetailId { get; set; }

        ///<summary>Date the product is expected to be received.</summary>
        [Column("DueDate", Order = 2, TypeName = "datetime")]
        public DateTime DueDate { get; set; }

        ///<summary>Quantity ordered.</summary>
        [Column("OrderQty", Order = 3, TypeName = "smallint")]
        public short OrderQty { get; set; }

        ///<summary>Product identification number. Foreign key to Product.ProductID.</summary>
        [Column("ProductID")]
        public int ProductId { get; set; }

        ///<summary>Vendor's selling price of a single product.</summary>
        [Column("UnitPrice", Order = 5, TypeName = "money")]
        public decimal UnitPrice { get; set; }

        ///<summary>Per product subtotal. Computed as OrderQty * UnitPrice.</summary>
        [Column("LineTotal", Order = 6, TypeName = "money")]
        public decimal LineTotal { get; set; }

        ///<summary>Quantity actually received from the vendor.</summary>
        [Column("ReceivedQty", Order = 7, TypeName = "decimal")]
        public decimal ReceivedQty { get; set; }

        ///<summary>Quantity rejected during inspection.</summary>
        [Column("RejectedQty", Order = 8, TypeName = "decimal")]
        public decimal RejectedQty { get; set; }

        ///<summary>Quantity accepted into inventory. Computed as ReceivedQty - RejectedQty.</summary>
        [Column("StockedQty", Order = 9, TypeName = "decimal")]
        public decimal StockedQty { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 10, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

        public virtual PurchaseOrderHeader PurchaseOrderHeader { get; set; }

    }
}
