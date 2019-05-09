using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Production.Product_ondisk")]
    public partial class ProductOndisk
    {
        public ProductOndisk()
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
            SpecialOfferProductOndisks = new HashSet<SpecialOfferProductOndisk>();

        }

        ///<summary>column:ProductID</summary>
        [Key]
        [Column("ProductID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        ///<summary>column:Name</summary>
        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>column:ProductNumber</summary>
        [Required]
        [Column("ProductNumber", Order = 2, TypeName = "nvarchar")]
        [StringLength(25)]
        public string ProductNumber { get; set; }

        ///<summary>column:MakeFlag</summary>
        [Column("MakeFlag", Order = 3, TypeName = "bit")]
        public bool MakeFlag { get; set; }

        ///<summary>column:FinishedGoodsFlag</summary>
        [Column("FinishedGoodsFlag", Order = 4, TypeName = "bit")]
        public bool FinishedGoodsFlag { get; set; }

        ///<summary>column:Color</summary>
        [Column("Color", Order = 5, TypeName = "nvarchar")]
        [StringLength(15)]
        public string Color { get; set; }

        ///<summary>column:SafetyStockLevel</summary>
        [Column("SafetyStockLevel", Order = 6, TypeName = "smallint")]
        public short SafetyStockLevel { get; set; }

        ///<summary>column:ReorderPoint</summary>
        [Column("ReorderPoint", Order = 7, TypeName = "smallint")]
        public short ReorderPoint { get; set; }

        ///<summary>column:StandardCost</summary>
        [Column("StandardCost", Order = 8, TypeName = "money")]
        public decimal StandardCost { get; set; }

        ///<summary>column:ListPrice</summary>
        [Column("ListPrice", Order = 9, TypeName = "money")]
        public decimal ListPrice { get; set; }

        ///<summary>column:Size</summary>
        [Column("Size", Order = 10, TypeName = "nvarchar")]
        [StringLength(5)]
        public string Size { get; set; }

        ///<summary>column:SizeUnitMeasureCode</summary>
        [Column("SizeUnitMeasureCode", Order = 11, TypeName = "nchar")]
        [StringLength(3)]
        public string SizeUnitMeasureCode { get; set; }

        ///<summary>column:WeightUnitMeasureCode</summary>
        [Column("WeightUnitMeasureCode", Order = 12, TypeName = "nchar")]
        [StringLength(3)]
        public string WeightUnitMeasureCode { get; set; }

        ///<summary>column:Weight</summary>
        [Column("Weight", Order = 13, TypeName = "decimal")]
        public decimal? Weight { get; set; }

        ///<summary>column:DaysToManufacture</summary>
        [Column("DaysToManufacture", Order = 14, TypeName = "int")]
        public int DaysToManufacture { get; set; }

        ///<summary>column:ProductLine</summary>
        [Column("ProductLine", Order = 15, TypeName = "nchar")]
        [StringLength(2)]
        public string ProductLine { get; set; }

        ///<summary>column:Class</summary>
        [Column("Class", Order = 16, TypeName = "nchar")]
        [StringLength(2)]
        public string Class { get; set; }

        ///<summary>column:Style</summary>
        [Column("Style", Order = 17, TypeName = "nchar")]
        [StringLength(2)]
        public string Style { get; set; }

        ///<summary>column:ProductSubcategoryID</summary>
        [Column("ProductSubcategoryID", Order = 18, TypeName = "int")]
        public int? ProductSubcategoryId { get; set; }

        ///<summary>column:ProductModelID</summary>
        [Column("ProductModelID", Order = 19, TypeName = "int")]
        public int? ProductModelId { get; set; }

        ///<summary>column:SellStartDate</summary>
        [Column("SellStartDate", Order = 20, TypeName = "datetime2")]
        public DateTime SellStartDate { get; set; }

        ///<summary>column:SellEndDate</summary>
        [Column("SellEndDate", Order = 21, TypeName = "datetime2")]
        public DateTime? SellEndDate { get; set; }

        ///<summary>column:DiscontinuedDate</summary>
        [Column("DiscontinuedDate", Order = 22, TypeName = "datetime2")]
        public DateTime? DiscontinuedDate { get; set; }

        ///<summary>column:ModifiedDate</summary>
        [Column("ModifiedDate", Order = 23, TypeName = "datetime2")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialOfferProductOndisk> SpecialOfferProductOndisks { get; set; }

    }
}
