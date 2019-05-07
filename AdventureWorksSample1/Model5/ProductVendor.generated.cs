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
        public ProductVendor()
        {
            ProductID = 0;
            BusinessEntityID = 0;
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

        [Key]
        [Column("ProductID", Order = 0, TypeName = "int")]
        public int ProductID { get; set; }

        [Key]
        [Column("BusinessEntityID", Order = 1, TypeName = "int")]
        public int BusinessEntityID { get; set; }

        [Column("AverageLeadTime", Order = 2, TypeName = "int")]
        public int AverageLeadTime { get; set; }

        [Column("StandardPrice", Order = 3, TypeName = "money")]
        public decimal StandardPrice { get; set; }

        [Column("LastReceiptCost", Order = 4, TypeName = "money")]
        public decimal? LastReceiptCost { get; set; }

        [Column("LastReceiptDate", Order = 5, TypeName = "datetime")]
        public DateTime? LastReceiptDate { get; set; }

        [Column("MinOrderQty", Order = 6, TypeName = "int")]
        public int MinOrderQty { get; set; }

        [Column("MaxOrderQty", Order = 7, TypeName = "int")]
        public int MaxOrderQty { get; set; }

        [Column("OnOrderQty", Order = 8, TypeName = "int")]
        public int? OnOrderQty { get; set; }

        [Required]
        [StringLength(3)]
        public string UnitMeasureCode { get; set; }

        [Column("ModifiedDate", Order = 10, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

        public virtual UnitMeasure UnitMeasure { get; set; }

        public virtual Vendor Vendor { get; set; }

    }
}
