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
        public SalesOrderDetail()
        {
            SalesOrderID = 0;
            SalesOrderDetailID = 0;
            CarrierTrackingNumber = null;
            OrderQty = 0;
            ProductID = 0;
            SpecialOfferID = 0;
            UnitPrice = 0;
            UnitPriceDiscount = 0;
            LineTotal = 0;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("SalesOrderID", Order = 0, TypeName = "int")]
        public int SalesOrderID { get; set; }

        [Key]
        [Column("SalesOrderDetailID", Order = 1, TypeName = "int")]
        public int SalesOrderDetailID { get; set; }

        [Column("CarrierTrackingNumber", Order = 2, TypeName = "nvarchar")]
        [StringLength(25)]
        public string CarrierTrackingNumber { get; set; }

        [Column("OrderQty", Order = 3, TypeName = "smallint")]
        public short OrderQty { get; set; }

        public int ProductID { get; set; }

        public int SpecialOfferID { get; set; }

        [Column("UnitPrice", Order = 6, TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column("UnitPriceDiscount", Order = 7, TypeName = "money")]
        public decimal UnitPriceDiscount { get; set; }

        [Column("LineTotal", Order = 8, TypeName = "numeric")]
        public decimal LineTotal { get; set; }

        [Column("rowguid", Order = 9, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 10, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual SalesOrderHeader SalesOrderHeader { get; set; }

        public virtual SpecialOfferProduct SpecialOfferProduct { get; set; }

    }
}
