using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Purchasing.ProductVendor")]
    public partial class ProductVendor
    {
        [Key]
        [Column("ProductID", Order = 1, TypeName = "int")]
        public int ProductId { get; set; }
        [Key]
        [Column("BusinessEntityID", Order = 2, TypeName = "int")]
        public int BusinessEntityId { get; set; }
        [Column("AverageLeadTime", Order = 3, TypeName = "int")]
        public int AverageLeadTime { get; set; }
        [Column("StandardPrice", Order = 4, TypeName = "money")]
        public decimal StandardPrice { get; set; }
        [Column("LastReceiptCost", Order = 5, TypeName = "money")]
        public decimal? LastReceiptCost { get; set; }
        [Column("LastReceiptDate", Order = 6, TypeName = "datetime")]
        public DateTime? LastReceiptDate { get; set; }
        [Column("MinOrderQty", Order = 7, TypeName = "int")]
        public int MinOrderQty { get; set; }
        [Column("MaxOrderQty", Order = 8, TypeName = "int")]
        public int MaxOrderQty { get; set; }
        [Column("OnOrderQty", Order = 9, TypeName = "int")]
        public int? OnOrderQty { get; set; }
        [Column("UnitMeasureCode", Order = 10, TypeName = "nchar")]
        [StringLength(3)]
        public string UnitMeasureCode { get; set; }
        [Column("ModifiedDate", Order = 11, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
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
    }
}
