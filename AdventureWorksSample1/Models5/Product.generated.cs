using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Production.Product")]
    public partial class Product
    {
        public Product()
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
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            ComponentBillOfMaterials = new HashSet<BillOfMaterials>();
            ProductAssemblyBillOfMaterials = new HashSet<BillOfMaterials>();
            ProductCostHistories = new HashSet<ProductCostHistory>();
            ProductInventories = new HashSet<ProductInventory>();
            ProductListPriceHistories = new HashSet<ProductListPriceHistory>();
            ProductProductPhotos = new HashSet<ProductProductPhoto>();
            ProductReviews = new HashSet<ProductReview>();
            ProductVendors = new HashSet<ProductVendor>();
            PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
            ShoppingCartItems = new HashSet<ShoppingCartItem>();
            SpecialOfferProducts = new HashSet<SpecialOfferProduct>();
            TransactionHistories = new HashSet<TransactionHistory>();
            WorkOrders = new HashSet<WorkOrder>();

        }

        ///<summary>Primary key for Product records.</summary>
        [Key]
        [Column("ProductID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        ///<summary>Name of the product.</summary>
        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>Unique product identification number.</summary>
        [Required]
        [Column("ProductNumber", Order = 2, TypeName = "nvarchar")]
        [StringLength(25)]
        public string ProductNumber { get; set; }

        ///<summary>0 = Product is purchased, 1 = Product is manufactured in-house.</summary>
        [Column("MakeFlag", Order = 3, TypeName = "bit")]
        public bool MakeFlag { get; set; }

        ///<summary>0 = Product is not a salable item. 1 = Product is salable.</summary>
        [Column("FinishedGoodsFlag", Order = 4, TypeName = "bit")]
        public bool FinishedGoodsFlag { get; set; }

        ///<summary>Product color.</summary>
        [Column("Color", Order = 5, TypeName = "nvarchar")]
        [StringLength(15)]
        public string Color { get; set; }

        ///<summary>Minimum inventory quantity. </summary>
        [Column("SafetyStockLevel", Order = 6, TypeName = "smallint")]
        public short SafetyStockLevel { get; set; }

        ///<summary>Inventory level that triggers a purchase order or work order. </summary>
        [Column("ReorderPoint", Order = 7, TypeName = "smallint")]
        public short ReorderPoint { get; set; }

        ///<summary>Standard cost of the product.</summary>
        [Column("StandardCost", Order = 8, TypeName = "money")]
        public decimal StandardCost { get; set; }

        ///<summary>Selling price.</summary>
        [Column("ListPrice", Order = 9, TypeName = "money")]
        public decimal ListPrice { get; set; }

        ///<summary>Product size.</summary>
        [Column("Size", Order = 10, TypeName = "nvarchar")]
        [StringLength(5)]
        public string Size { get; set; }

        ///<summary>Unit of measure for Size column.</summary>
        [Column("SizeUnitMeasureCode")]
        [StringLength(3)]
        public string SizeUnitMeasureCode { get; set; }

        ///<summary>Unit of measure for Weight column.</summary>
        [Column("WeightUnitMeasureCode")]
        [StringLength(3)]
        public string WeightUnitMeasureCode { get; set; }

        ///<summary>Product weight.</summary>
        [Column("Weight", Order = 13, TypeName = "decimal")]
        public decimal? Weight { get; set; }

        ///<summary>Number of days required to manufacture the product.</summary>
        [Column("DaysToManufacture", Order = 14, TypeName = "int")]
        public int DaysToManufacture { get; set; }

        ///<summary>R = Road, M = Mountain, T = Touring, S = Standard</summary>
        [Column("ProductLine", Order = 15, TypeName = "nchar")]
        [StringLength(2)]
        public string ProductLine { get; set; }

        ///<summary>H = High, M = Medium, L = Low</summary>
        [Column("Class", Order = 16, TypeName = "nchar")]
        [StringLength(2)]
        public string Class { get; set; }

        ///<summary>W = Womens, M = Mens, U = Universal</summary>
        [Column("Style", Order = 17, TypeName = "nchar")]
        [StringLength(2)]
        public string Style { get; set; }

        ///<summary>Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID. </summary>
        [Column("ProductSubcategoryID")]
        public int? ProductSubcategoryId { get; set; }

        ///<summary>Product is a member of this product model. Foreign key to ProductModel.ProductModelID.</summary>
        [Column("ProductModelID")]
        public int? ProductModelId { get; set; }

        ///<summary>Date the product was available for sale.</summary>
        [Column("SellStartDate", Order = 20, TypeName = "datetime")]
        public DateTime SellStartDate { get; set; }

        ///<summary>Date the product was no longer available for sale.</summary>
        [Column("SellEndDate", Order = 21, TypeName = "datetime")]
        public DateTime? SellEndDate { get; set; }

        ///<summary>Date the product was discontinued.</summary>
        [Column("DiscontinuedDate", Order = 22, TypeName = "datetime")]
        public DateTime? DiscontinuedDate { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 23, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 24, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillOfMaterials> ComponentBillOfMaterials { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillOfMaterials> ProductAssemblyBillOfMaterials { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductCostHistory> ProductCostHistories { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductListPriceHistory> ProductListPriceHistories { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductProductPhoto> ProductProductPhotos { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductReview> ProductReviews { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }

        public virtual ProductModel ProductModel { get; set; }

        public virtual ProductSubcategory ProductSubcategory { get; set; }

        public virtual UnitMeasure SizeUnitMeasure { get; set; }

        public virtual UnitMeasure WeightUnitMeasure { get; set; }

    }
}
