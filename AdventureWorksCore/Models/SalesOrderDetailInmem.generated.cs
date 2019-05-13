using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("SalesOrderDetail_inmem", Schema="Sales")]
    public partial class SalesOrderDetailInmem
    {
        public SalesOrderDetailInmem()
        {

        }

        ///<summary>column:SalesOrderID</summary>
        ///<remarks></remarks>
        [Key]
        [Column("SalesOrderID", Order = 0)]
        public int SalesOrderId { get; set; }

        ///<summary>column:SalesOrderDetailID</summary>
        ///<remarks></remarks>
        [Key]
        [Column("SalesOrderDetailID", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SalesOrderDetailId { get; set; }

        ///<summary>column:CarrierTrackingNumber</summary>
        ///<remarks></remarks>
        [Column("CarrierTrackingNumber", Order = 2)]
        [StringLength(25)]
        public string CarrierTrackingNumber { get; set; }

        ///<summary>column:OrderQty</summary>
        ///<remarks></remarks>
        [Column("OrderQty", Order = 3)]
        public short OrderQty { get; set; }

        ///<summary>column:ProductID</summary>
        ///<remarks></remarks>
        [Column("ProductID")]
        public int ProductId { get; set; }

        ///<summary>column:SpecialOfferID</summary>
        ///<remarks></remarks>
        [Column("SpecialOfferID")]
        public int SpecialOfferId { get; set; }

        ///<summary>column:UnitPrice</summary>
        ///<remarks></remarks>
        [Column("UnitPrice", Order = 6)]
        public decimal UnitPrice { get; set; }

        ///<summary>column:UnitPriceDiscount</summary>
        ///<remarks></remarks>
        [Column("UnitPriceDiscount", Order = 7)]
        public decimal UnitPriceDiscount { get; set; }

        ///<summary>column:ModifiedDate</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 8)]
        public DateTime ModifiedDate { get; set; }

        public virtual SalesOrderHeaderInmem SalesOrderHeaderInmem { get; set; }

        public virtual SpecialOfferProductInmem SpecialOfferProductInmem { get; set; }

    }
}
