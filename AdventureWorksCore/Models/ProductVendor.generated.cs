using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("ProductVendor", Schema="Purchasing")]
    public partial class ProductVendor
    {
        public ProductVendor()
        {

        }

        ///<summary>Primary key. Foreign key to Product.ProductID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ProductID", Order = 0)]
        public int ProductId { get; set; }

        ///<summary>Primary key. Foreign key to Vendor.BusinessEntityID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("BusinessEntityID", Order = 1)]
        public int BusinessEntityId { get; set; }

        ///<summary>The average span of time (in days) between placing an order with the vendor and receiving the purchased product.</summary>
        ///<remarks></remarks>
        [Column("AverageLeadTime", Order = 2)]
        public int AverageLeadTime { get; set; }

        ///<summary>The vendor's usual selling price.</summary>
        ///<remarks></remarks>
        [Column("StandardPrice", Order = 3)]
        public decimal StandardPrice { get; set; }

        ///<summary>The selling price when last purchased.</summary>
        ///<remarks></remarks>
        [Column("LastReceiptCost", Order = 4)]
        public decimal? LastReceiptCost { get; set; }

        ///<summary>Date the product was last received by the vendor.</summary>
        ///<remarks></remarks>
        [Column("LastReceiptDate", Order = 5)]
        public DateTime? LastReceiptDate { get; set; }

        ///<summary>The maximum quantity that should be ordered.</summary>
        ///<remarks></remarks>
        [Column("MinOrderQty", Order = 6)]
        public int MinOrderQty { get; set; }

        ///<summary>The minimum quantity that should be ordered.</summary>
        ///<remarks></remarks>
        [Column("MaxOrderQty", Order = 7)]
        public int MaxOrderQty { get; set; }

        ///<summary>The quantity currently on order.</summary>
        ///<remarks></remarks>
        [Column("OnOrderQty", Order = 8)]
        public int? OnOrderQty { get; set; }

        ///<summary>The product's unit of measure.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("UnitMeasureCode")]
        [StringLength(3)]
        public string UnitMeasureCode { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 10)]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

        public virtual UnitMeasure UnitMeasure { get; set; }

        public virtual Vendor Vendor { get; set; }

    }
}
