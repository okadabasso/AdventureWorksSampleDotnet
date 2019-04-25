using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.SalesOrderDetail")]
    public partial class SalesOrderDetail
    {
        [Key]
        [Column("SalesOrderID", Order = 1, TypeName = "int")]
        public int SalesOrderId { get; set; }
        [Key]
        [Column("SalesOrderDetailID", Order = 2, TypeName = "int")]
        public int SalesOrderDetailId { get; set; }
        [Column("CarrierTrackingNumber", Order = 3, TypeName = "nvarchar")]
        [StringLength(25)]
        public string CarrierTrackingNumber { get; set; }
        [Column("OrderQty", Order = 4, TypeName = "smallint")]
        public short OrderQty { get; set; }
        [Column("ProductID", Order = 5, TypeName = "int")]
        public int ProductId { get; set; }
        [Column("SpecialOfferID", Order = 6, TypeName = "int")]
        public int SpecialOfferId { get; set; }
        [Column("UnitPrice", Order = 7, TypeName = "money")]
        public decimal UnitPrice { get; set; }
        [Column("UnitPriceDiscount", Order = 8, TypeName = "money")]
        public decimal UnitPriceDiscount { get; set; }
        [Column("LineTotal", Order = 9, TypeName = "numeric")]
        public decimal LineTotal { get; set; }
        [Column("rowguid", Order = 10, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }
        [Column("ModifiedDate", Order = 11, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public SalesOrderDetail()
        {
            SalesOrderId = 0;
            SalesOrderDetailId = 0;
            CarrierTrackingNumber = null;
            OrderQty = 0;
            ProductId = 0;
            SpecialOfferId = 0;
            UnitPrice = 0;
            UnitPriceDiscount = 0;
            LineTotal = 0;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
