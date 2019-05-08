using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Sales.SalesOrderDetail")]
    public partial class SalesOrderDetail
    {
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

        ///<summary>Primary key. Foreign key to SalesOrderHeader.SalesOrderID.</summary>
        [Key]
        [Column("SalesOrderID", Order = 0, TypeName = "int")]
        public int SalesOrderId { get; set; }

        ///<summary>Primary key. One incremental unique number per product sold.</summary>
        [Key]
        [Column("SalesOrderDetailID", Order = 1, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesOrderDetailId { get; set; }

        ///<summary>Shipment tracking number supplied by the shipper.</summary>
        [Column("CarrierTrackingNumber", Order = 2, TypeName = "nvarchar")]
        [StringLength(25)]
        public string CarrierTrackingNumber { get; set; }

        ///<summary>Quantity ordered per product.</summary>
        [Column("OrderQty", Order = 3, TypeName = "smallint")]
        public short OrderQty { get; set; }

        ///<summary>Product sold to customer. Foreign key to Product.ProductID.</summary>
        [Column("ProductID")]
        public int ProductId { get; set; }

        ///<summary>Promotional code. Foreign key to SpecialOffer.SpecialOfferID.</summary>
        [Column("SpecialOfferID")]
        public int SpecialOfferId { get; set; }

        ///<summary>Selling price of a single product.</summary>
        [Column("UnitPrice", Order = 6, TypeName = "money")]
        public decimal UnitPrice { get; set; }

        ///<summary>Discount amount.</summary>
        [Column("UnitPriceDiscount", Order = 7, TypeName = "money")]
        public decimal UnitPriceDiscount { get; set; }

        ///<summary>Per product subtotal. Computed as UnitPrice * (1 - UnitPriceDiscount) * OrderQty.</summary>
        [Column("LineTotal", Order = 8, TypeName = "numeric")]
        public decimal LineTotal { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 9, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 10, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual SalesOrderHeader SalesOrderHeader { get; set; }

        public virtual SpecialOfferProduct SpecialOfferProduct { get; set; }

    }
}
