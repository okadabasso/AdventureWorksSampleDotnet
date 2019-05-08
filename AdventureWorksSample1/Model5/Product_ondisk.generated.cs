using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.Product_ondisk")]
    public partial class Product_ondisk
    {
        public Product_ondisk()
        {
            ProductID = 0;
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
            ProductSubcategoryID = null;
            ProductModelID = null;
            SellStartDate = DateTime.Parse("0001/01/01 0:00:00");
            SellEndDate = null;
            DiscontinuedDate = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            SpecialOfferProduct_ondisks = new HashSet<SpecialOfferProduct_ondisk>();

        }

        [Key]
        [Column("ProductID", Order = 0, TypeName = "int")]
        public int ProductID { get; set; }

        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Column("ProductNumber", Order = 2, TypeName = "nvarchar")]
        [StringLength(25)]
        public string ProductNumber { get; set; }

        [Column("MakeFlag", Order = 3, TypeName = "bit")]
        public bool MakeFlag { get; set; }

        [Column("FinishedGoodsFlag", Order = 4, TypeName = "bit")]
        public bool FinishedGoodsFlag { get; set; }

        [Column("Color", Order = 5, TypeName = "nvarchar")]
        [StringLength(15)]
        public string Color { get; set; }

        [Column("SafetyStockLevel", Order = 6, TypeName = "smallint")]
        public short SafetyStockLevel { get; set; }

        [Column("ReorderPoint", Order = 7, TypeName = "smallint")]
        public short ReorderPoint { get; set; }

        [Column("StandardCost", Order = 8, TypeName = "money")]
        public decimal StandardCost { get; set; }

        [Column("ListPrice", Order = 9, TypeName = "money")]
        public decimal ListPrice { get; set; }

        [Column("Size", Order = 10, TypeName = "nvarchar")]
        [StringLength(5)]
        public string Size { get; set; }

        [Column("SizeUnitMeasureCode", Order = 11, TypeName = "nchar")]
        [StringLength(3)]
        public string SizeUnitMeasureCode { get; set; }

        [Column("WeightUnitMeasureCode", Order = 12, TypeName = "nchar")]
        [StringLength(3)]
        public string WeightUnitMeasureCode { get; set; }

        [Column("Weight", Order = 13, TypeName = "decimal")]
        public decimal? Weight { get; set; }

        [Column("DaysToManufacture", Order = 14, TypeName = "int")]
        public int DaysToManufacture { get; set; }

        [Column("ProductLine", Order = 15, TypeName = "nchar")]
        [StringLength(2)]
        public string ProductLine { get; set; }

        [Column("Class", Order = 16, TypeName = "nchar")]
        [StringLength(2)]
        public string Class { get; set; }

        [Column("Style", Order = 17, TypeName = "nchar")]
        [StringLength(2)]
        public string Style { get; set; }

        [Column("ProductSubcategoryID", Order = 18, TypeName = "int")]
        public int? ProductSubcategoryID { get; set; }

        [Column("ProductModelID", Order = 19, TypeName = "int")]
        public int? ProductModelID { get; set; }

        [Column("SellStartDate", Order = 20, TypeName = "datetime2")]
        public DateTime SellStartDate { get; set; }

        [Column("SellEndDate", Order = 21, TypeName = "datetime2")]
        public DateTime? SellEndDate { get; set; }

        [Column("DiscontinuedDate", Order = 22, TypeName = "datetime2")]
        public DateTime? DiscontinuedDate { get; set; }

        [Column("ModifiedDate", Order = 23, TypeName = "datetime2")]
        public DateTime ModifiedDate { get; set; }

//SpecialOfferProduct_ondisk Product_ondisk
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialOfferProduct_ondisk> SpecialOfferProduct_ondisks { get; set; }

    }
}
