using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("SalesOrderDetail", Schema="Sales")]
    public partial class SalesOrderDetail
    {
        public SalesOrderDetail()
        {

        }

        ///<summary>Primary key. Foreign key to SalesOrderHeader.SalesOrderID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("SalesOrderID", Order = 0)]
        public int SalesOrderId { get; set; }

        ///<summary>Primary key. One incremental unique number per product sold.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("SalesOrderDetailID", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesOrderDetailId { get; set; }

        ///<summary>Shipment tracking number supplied by the shipper.</summary>
        ///<remarks></remarks>
        [Column("CarrierTrackingNumber", Order = 2)]
        [StringLength(25)]
        public string CarrierTrackingNumber { get; set; }

        ///<summary>Quantity ordered per product.</summary>
        ///<remarks></remarks>
        [Column("OrderQty", Order = 3)]
        public short OrderQty { get; set; }

        ///<summary>Product sold to customer. Foreign key to Product.ProductID.</summary>
        ///<remarks></remarks>
        [Column("ProductID")]
        public int ProductId { get; set; }

        ///<summary>Promotional code. Foreign key to SpecialOffer.SpecialOfferID.</summary>
        ///<remarks></remarks>
        [Column("SpecialOfferID")]
        public int SpecialOfferId { get; set; }

        ///<summary>Selling price of a single product.</summary>
        ///<remarks></remarks>
        [Column("UnitPrice", Order = 6)]
        public decimal UnitPrice { get; set; }

        ///<summary>Discount amount.</summary>
        ///<remarks></remarks>
        [Column("UnitPriceDiscount", Order = 7)]
        public decimal UnitPriceDiscount { get; set; }

        ///<summary>Per product subtotal. Computed as UnitPrice * (1 - UnitPriceDiscount) * OrderQty.</summary>
        ///<remarks></remarks>
        [Column("LineTotal", Order = 8)]
        public decimal LineTotal { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 9)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 10)]
        public DateTime ModifiedDate { get; set; }

        public virtual SalesOrderHeader SalesOrderHeader { get; set; }

        public virtual SpecialOfferProduct SpecialOfferProduct { get; set; }

    }
}
