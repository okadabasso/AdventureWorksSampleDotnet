using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Purchasing.ProductVendor")]
    public partial class ProductVendor
    {
        public ProductVendor()
        {
            ProductId = 0;
            BusinessEntityId = 0;
            AverageLeadTime = 0;
            StandardPrice = 0;
            LastReceiptCost = null;
            LastReceiptDate = null;
            MinOrderQty = 0;
            MaxOrderQty = 0;
            OnOrderQty = null;
            UnitMeasureCode = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Primary key. Foreign key to Product.ProductID.</summary>
        [Key]
        [Column("ProductID", Order = 0, TypeName = "int")]
        public int ProductId { get; set; }

        ///<summary>Primary key. Foreign key to Vendor.BusinessEntityID.</summary>
        [Key]
        [Column("BusinessEntityID", Order = 1, TypeName = "int")]
        public int BusinessEntityId { get; set; }

        ///<summary>The average span of time (in days) between placing an order with the vendor and receiving the purchased product.</summary>
        [Column("AverageLeadTime", Order = 2, TypeName = "int")]
        public int AverageLeadTime { get; set; }

        ///<summary>The vendor's usual selling price.</summary>
        [Column("StandardPrice", Order = 3, TypeName = "money")]
        public decimal StandardPrice { get; set; }

        ///<summary>The selling price when last purchased.</summary>
        [Column("LastReceiptCost", Order = 4, TypeName = "money")]
        public decimal? LastReceiptCost { get; set; }

        ///<summary>Date the product was last received by the vendor.</summary>
        [Column("LastReceiptDate", Order = 5, TypeName = "datetime")]
        public DateTime? LastReceiptDate { get; set; }

        ///<summary>The maximum quantity that should be ordered.</summary>
        [Column("MinOrderQty", Order = 6, TypeName = "int")]
        public int MinOrderQty { get; set; }

        ///<summary>The minimum quantity that should be ordered.</summary>
        [Column("MaxOrderQty", Order = 7, TypeName = "int")]
        public int MaxOrderQty { get; set; }

        ///<summary>The quantity currently on order.</summary>
        [Column("OnOrderQty", Order = 8, TypeName = "int")]
        public int? OnOrderQty { get; set; }

        ///<summary>The product's unit of measure.</summary>
        [Required]
        [Column("UnitMeasureCode")]
        [StringLength(3)]
        public string UnitMeasureCode { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 10, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

        public virtual UnitMeasure UnitMeasure { get; set; }

        public virtual Vendor Vendor { get; set; }

    }
}
