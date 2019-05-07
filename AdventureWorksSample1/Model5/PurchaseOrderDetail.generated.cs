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
        public PurchaseOrderDetail()
        {
            PurchaseOrderID = 0;
            PurchaseOrderDetailID = 0;
            DueDate = DateTime.Parse("0001/01/01 0:00:00");
            OrderQty = 0;
            ProductID = 0;
            UnitPrice = 0;
            LineTotal = 0;
            ReceivedQty = 0;
            RejectedQty = 0;
            StockedQty = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("PurchaseOrderID", Order = 0, TypeName = "int")]
        public int PurchaseOrderID { get; set; }

        [Key]
        [Column("PurchaseOrderDetailID", Order = 1, TypeName = "int")]
        public int PurchaseOrderDetailID { get; set; }

        [Column("DueDate", Order = 2, TypeName = "datetime")]
        public DateTime DueDate { get; set; }

        [Column("OrderQty", Order = 3, TypeName = "smallint")]
        public short OrderQty { get; set; }

        public int ProductID { get; set; }

        [Column("UnitPrice", Order = 5, TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column("LineTotal", Order = 6, TypeName = "money")]
        public decimal LineTotal { get; set; }

        [Column("ReceivedQty", Order = 7, TypeName = "decimal")]
        public decimal ReceivedQty { get; set; }

        [Column("RejectedQty", Order = 8, TypeName = "decimal")]
        public decimal RejectedQty { get; set; }

        [Column("StockedQty", Order = 9, TypeName = "decimal")]
        public decimal StockedQty { get; set; }

        [Column("ModifiedDate", Order = 10, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

        public virtual PurchaseOrderHeader PurchaseOrderHeader { get; set; }

    }
}
