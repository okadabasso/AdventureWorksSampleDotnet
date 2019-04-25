using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Purchasing.PurchaseOrderDetail")]
    public partial class PurchaseOrderDetail
    {
        [Key]
        [Column("PurchaseOrderID", Order = 1, TypeName = "int")]
        public int PurchaseOrderId { get; set; }
        [Key]
        [Column("PurchaseOrderDetailID", Order = 2, TypeName = "int")]
        public int PurchaseOrderDetailId { get; set; }
        [Column("DueDate", Order = 3, TypeName = "datetime")]
        public DateTime DueDate { get; set; }
        [Column("OrderQty", Order = 4, TypeName = "smallint")]
        public short OrderQty { get; set; }
        [Column("ProductID", Order = 5, TypeName = "int")]
        public int ProductId { get; set; }
        [Column("UnitPrice", Order = 6, TypeName = "money")]
        public decimal UnitPrice { get; set; }
        [Column("LineTotal", Order = 7, TypeName = "money")]
        public decimal LineTotal { get; set; }
        [Column("ReceivedQty", Order = 8, TypeName = "decimal")]
        public decimal ReceivedQty { get; set; }
        [Column("RejectedQty", Order = 9, TypeName = "decimal")]
        public decimal RejectedQty { get; set; }
        [Column("StockedQty", Order = 10, TypeName = "decimal")]
        public decimal StockedQty { get; set; }
        [Column("ModifiedDate", Order = 11, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
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
    }
}
