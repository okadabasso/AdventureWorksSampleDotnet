using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("Product_ondisk", Schema="Production")]
    public partial class ProductOndisk
    {
        public ProductOndisk()
        {
            SpecialOfferProductOndisks = new HashSet<SpecialOfferProductOndisk>();

        }

        ///<summary>column:ProductID</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ProductID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        ///<summary>column:Name</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Name", Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>column:ProductNumber</summary>
        ///<remarks></remarks>
        [Required]
        [Column("ProductNumber", Order = 2)]
        [StringLength(25)]
        public string ProductNumber { get; set; }

        ///<summary>column:MakeFlag</summary>
        ///<remarks></remarks>
        [Column("MakeFlag", Order = 3)]
        public bool MakeFlag { get; set; }

        ///<summary>column:FinishedGoodsFlag</summary>
        ///<remarks></remarks>
        [Column("FinishedGoodsFlag", Order = 4)]
        public bool FinishedGoodsFlag { get; set; }

        ///<summary>column:Color</summary>
        ///<remarks></remarks>
        [Column("Color", Order = 5)]
        [StringLength(15)]
        public string Color { get; set; }

        ///<summary>column:SafetyStockLevel</summary>
        ///<remarks></remarks>
        [Column("SafetyStockLevel", Order = 6)]
        public short SafetyStockLevel { get; set; }

        ///<summary>column:ReorderPoint</summary>
        ///<remarks></remarks>
        [Column("ReorderPoint", Order = 7)]
        public short ReorderPoint { get; set; }

        ///<summary>column:StandardCost</summary>
        ///<remarks></remarks>
        [Column("StandardCost", Order = 8)]
        public decimal StandardCost { get; set; }

        ///<summary>column:ListPrice</summary>
        ///<remarks></remarks>
        [Column("ListPrice", Order = 9)]
        public decimal ListPrice { get; set; }

        ///<summary>column:Size</summary>
        ///<remarks></remarks>
        [Column("Size", Order = 10)]
        [StringLength(5)]
        public string Size { get; set; }

        ///<summary>column:SizeUnitMeasureCode</summary>
        ///<remarks></remarks>
        [Column("SizeUnitMeasureCode", Order = 11)]
        [StringLength(3)]
        public string SizeUnitMeasureCode { get; set; }

        ///<summary>column:WeightUnitMeasureCode</summary>
        ///<remarks></remarks>
        [Column("WeightUnitMeasureCode", Order = 12)]
        [StringLength(3)]
        public string WeightUnitMeasureCode { get; set; }

        ///<summary>column:Weight</summary>
        ///<remarks></remarks>
        [Column("Weight", Order = 13)]
        public decimal? Weight { get; set; }

        ///<summary>column:DaysToManufacture</summary>
        ///<remarks></remarks>
        [Column("DaysToManufacture", Order = 14)]
        public int DaysToManufacture { get; set; }

        ///<summary>column:ProductLine</summary>
        ///<remarks></remarks>
        [Column("ProductLine", Order = 15)]
        [StringLength(2)]
        public string ProductLine { get; set; }

        ///<summary>column:Class</summary>
        ///<remarks></remarks>
        [Column("Class", Order = 16)]
        [StringLength(2)]
        public string Class { get; set; }

        ///<summary>column:Style</summary>
        ///<remarks></remarks>
        [Column("Style", Order = 17)]
        [StringLength(2)]
        public string Style { get; set; }

        ///<summary>column:ProductSubcategoryID</summary>
        ///<remarks></remarks>
        [Column("ProductSubcategoryID", Order = 18)]
        public int? ProductSubcategoryId { get; set; }

        ///<summary>column:ProductModelID</summary>
        ///<remarks></remarks>
        [Column("ProductModelID", Order = 19)]
        public int? ProductModelId { get; set; }

        ///<summary>column:SellStartDate</summary>
        ///<remarks></remarks>
        [Column("SellStartDate", Order = 20)]
        public DateTime SellStartDate { get; set; }

        ///<summary>column:SellEndDate</summary>
        ///<remarks></remarks>
        [Column("SellEndDate", Order = 21)]
        public DateTime? SellEndDate { get; set; }

        ///<summary>column:DiscontinuedDate</summary>
        ///<remarks></remarks>
        [Column("DiscontinuedDate", Order = 22)]
        public DateTime? DiscontinuedDate { get; set; }

        ///<summary>column:ModifiedDate</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 23)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialOfferProductOndisk> SpecialOfferProductOndisks { get; set; }

    }
}
