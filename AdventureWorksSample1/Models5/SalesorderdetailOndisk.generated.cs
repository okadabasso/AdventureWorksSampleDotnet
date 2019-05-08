using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Sales.SalesOrderDetail_ondisk")]
    public partial class SalesorderdetailOndisk
    {
        public SalesorderdetailOndisk()
        {
            SalesOrderId = 0;
            SalesOrderDetailId = 0;
            CarrierTrackingNumber = null;
            OrderQty = 0;
            ProductId = 0;
            SpecialOfferId = 0;
            UnitPrice = 0;
            UnitPriceDiscount = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>column:SalesOrderID</summary>
        [Key]
        [Column("SalesOrderID", Order = 0, TypeName = "int")]
        public int SalesOrderId { get; set; }

        ///<summary>column:SalesOrderDetailID</summary>
        [Key]
        [Column("SalesOrderDetailID", Order = 1, TypeName = "bigint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SalesOrderDetailId { get; set; }

        ///<summary>column:CarrierTrackingNumber</summary>
        [Column("CarrierTrackingNumber", Order = 2, TypeName = "nvarchar")]
        [StringLength(25)]
        public string CarrierTrackingNumber { get; set; }

        ///<summary>column:OrderQty</summary>
        [Column("OrderQty", Order = 3, TypeName = "smallint")]
        public short OrderQty { get; set; }

        ///<summary>column:ProductID</summary>
        [Column("ProductID")]
        public int ProductId { get; set; }

        ///<summary>column:SpecialOfferID</summary>
        [Column("SpecialOfferID")]
        public int SpecialOfferId { get; set; }

        ///<summary>column:UnitPrice</summary>
        [Column("UnitPrice", Order = 6, TypeName = "money")]
        public decimal UnitPrice { get; set; }

        ///<summary>column:UnitPriceDiscount</summary>
        [Column("UnitPriceDiscount", Order = 7, TypeName = "money")]
        public decimal UnitPriceDiscount { get; set; }

        ///<summary>column:ModifiedDate</summary>
        [Column("ModifiedDate", Order = 8, TypeName = "datetime2")]
        public DateTime ModifiedDate { get; set; }

        public virtual SalesorderheaderOndisk SalesorderheaderOndisk { get; set; }

        public virtual SpecialofferproductOndisk SpecialofferproductOndisk { get; set; }

    }
}
