using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.Product_inmem")]
    public partial class ProductInmem
    {
        [Key]
        [Column("ProductID", Order = 1, TypeName = "int")]
        public int ProductId { get; set; }
        [Column("Name", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("ProductNumber", Order = 3, TypeName = "nvarchar")]
        [StringLength(25)]
        public string ProductNumber { get; set; }
        [Column("MakeFlag", Order = 4, TypeName = "bit")]
        public bool MakeFlag { get; set; }
        [Column("FinishedGoodsFlag", Order = 5, TypeName = "bit")]
        public bool FinishedGoodsFlag { get; set; }
        [Column("Color", Order = 6, TypeName = "nvarchar")]
        [StringLength(15)]
        public string Color { get; set; }
        [Column("SafetyStockLevel", Order = 7, TypeName = "smallint")]
        public short SafetyStockLevel { get; set; }
        [Column("ReorderPoint", Order = 8, TypeName = "smallint")]
        public short ReorderPoint { get; set; }
        [Column("StandardCost", Order = 9, TypeName = "money")]
        public decimal StandardCost { get; set; }
        [Column("ListPrice", Order = 10, TypeName = "money")]
        public decimal ListPrice { get; set; }
        [Column("Size", Order = 11, TypeName = "nvarchar")]
        [StringLength(5)]
        public string Size { get; set; }
        [Column("SizeUnitMeasureCode", Order = 12, TypeName = "nchar")]
        [StringLength(3)]
        public string SizeUnitMeasureCode { get; set; }
        [Column("WeightUnitMeasureCode", Order = 13, TypeName = "nchar")]
        [StringLength(3)]
        public string WeightUnitMeasureCode { get; set; }
        [Column("Weight", Order = 14, TypeName = "decimal")]
        public decimal? Weight { get; set; }
        [Column("DaysToManufacture", Order = 15, TypeName = "int")]
        public int DaysToManufacture { get; set; }
        [Column("ProductLine", Order = 16, TypeName = "nchar")]
        [StringLength(2)]
        public string ProductLine { get; set; }
        [Column("Class", Order = 17, TypeName = "nchar")]
        [StringLength(2)]
        public string Class { get; set; }
        [Column("Style", Order = 18, TypeName = "nchar")]
        [StringLength(2)]
        public string Style { get; set; }
        [Column("ProductSubcategoryID", Order = 19, TypeName = "int")]
        public int? ProductSubcategoryId { get; set; }
        [Column("ProductModelID", Order = 20, TypeName = "int")]
        public int? ProductModelId { get; set; }
        [Column("SellStartDate", Order = 21, TypeName = "datetime2")]
        public DateTime SellStartDate { get; set; }
        [Column("SellEndDate", Order = 22, TypeName = "datetime2")]
        public DateTime? SellEndDate { get; set; }
        [Column("DiscontinuedDate", Order = 23, TypeName = "datetime2")]
        public DateTime? DiscontinuedDate { get; set; }
        [Column("ModifiedDate", Order = 24, TypeName = "datetime2")]
        public DateTime ModifiedDate { get; set; }
        public ProductInmem()
        {
            ProductId = 0;
            Name = null;
            ProductNumber = null;
            MakeFlag = false;
            FinishedGoodsFlag = false;
            Color = null;
            SafetyStockLevel = 0;
            ReorderPoint = 0;
            StandardCost = 0;
            ListPrice = 0;
            Size = null;
            SizeUnitMeasureCode = null;
            WeightUnitMeasureCode = null;
            Weight = null;
            DaysToManufacture = 0;
            ProductLine = null;
            Class = null;
            Style = null;
            ProductSubcategoryId = null;
            ProductModelId = null;
            SellStartDate = DateTime.Parse("0001/01/01 0:00:00");
            SellEndDate = null;
            DiscontinuedDate = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
