using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("Product", Schema="Production")]
    public partial class Product
    {
        public Product()
        {
            ComponentBillOfMaterials = new HashSet<BillOfMaterials>();
            ProductAssemblyBillOfMaterials = new HashSet<BillOfMaterials>();
            ProductCostHistories = new HashSet<ProductCostHistory>();
            ProductInventories = new HashSet<ProductInventory>();
            ProductListPriceHistories = new HashSet<ProductListPriceHistory>();
            ProductProductPhotos = new HashSet<ProductProductPhoto>();
            ProductReviews = new HashSet<ProductReview>();
            TransactionHistories = new HashSet<TransactionHistory>();
            WorkOrders = new HashSet<WorkOrder>();
            ProductVendors = new HashSet<ProductVendor>();
            PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
            ShoppingCartItems = new HashSet<ShoppingCartItem>();
            SpecialOfferProducts = new HashSet<SpecialOfferProduct>();

        }

        ///<summary>Primary key for Product records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ProductID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        ///<summary>Name of the product.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Name", Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>Unique product identification number.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("ProductNumber", Order = 2)]
        [StringLength(25)]
        public string ProductNumber { get; set; }

        ///<summary>0 = Product is purchased, 1 = Product is manufactured in-house.</summary>
        ///<remarks></remarks>
        [Column("MakeFlag", Order = 3)]
        public bool MakeFlag { get; set; }

        ///<summary>0 = Product is not a salable item. 1 = Product is salable.</summary>
        ///<remarks></remarks>
        [Column("FinishedGoodsFlag", Order = 4)]
        public bool FinishedGoodsFlag { get; set; }

        ///<summary>Product color.</summary>
        ///<remarks></remarks>
        [Column("Color", Order = 5)]
        [StringLength(15)]
        public string Color { get; set; }

        ///<summary>Minimum inventory quantity. </summary>
        ///<remarks></remarks>
        [Column("SafetyStockLevel", Order = 6)]
        public short SafetyStockLevel { get; set; }

        ///<summary>Inventory level that triggers a purchase order or work order. </summary>
        ///<remarks></remarks>
        [Column("ReorderPoint", Order = 7)]
        public short ReorderPoint { get; set; }

        ///<summary>Standard cost of the product.</summary>
        ///<remarks></remarks>
        [Column("StandardCost", Order = 8)]
        public decimal StandardCost { get; set; }

        ///<summary>Selling price.</summary>
        ///<remarks></remarks>
        [Column("ListPrice", Order = 9)]
        public decimal ListPrice { get; set; }

        ///<summary>Product size.</summary>
        ///<remarks></remarks>
        [Column("Size", Order = 10)]
        [StringLength(5)]
        public string Size { get; set; }

        ///<summary>Unit of measure for Size column.</summary>
        ///<remarks></remarks>
        [Column("SizeUnitMeasureCode")]
        [StringLength(3)]
        public string SizeUnitMeasureCode { get; set; }

        ///<summary>Unit of measure for Weight column.</summary>
        ///<remarks></remarks>
        [Column("WeightUnitMeasureCode")]
        [StringLength(3)]
        public string WeightUnitMeasureCode { get; set; }

        ///<summary>Product weight.</summary>
        ///<remarks></remarks>
        [Column("Weight", Order = 13)]
        public decimal? Weight { get; set; }

        ///<summary>Number of days required to manufacture the product.</summary>
        ///<remarks></remarks>
        [Column("DaysToManufacture", Order = 14)]
        public int DaysToManufacture { get; set; }

        ///<summary>R = Road, M = Mountain, T = Touring, S = Standard</summary>
        ///<remarks></remarks>
        [Column("ProductLine", Order = 15)]
        [StringLength(2)]
        public string ProductLine { get; set; }

        ///<summary>H = High, M = Medium, L = Low</summary>
        ///<remarks></remarks>
        [Column("Class", Order = 16)]
        [StringLength(2)]
        public string Class { get; set; }

        ///<summary>W = Womens, M = Mens, U = Universal</summary>
        ///<remarks></remarks>
        [Column("Style", Order = 17)]
        [StringLength(2)]
        public string Style { get; set; }

        ///<summary>Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID. </summary>
        ///<remarks></remarks>
        [Column("ProductSubcategoryID")]
        public int? ProductSubcategoryId { get; set; }

        ///<summary>Product is a member of this product model. Foreign key to ProductModel.ProductModelID.</summary>
        ///<remarks></remarks>
        [Column("ProductModelID")]
        public int? ProductModelId { get; set; }

        ///<summary>Date the product was available for sale.</summary>
        ///<remarks></remarks>
        [Column("SellStartDate", Order = 20)]
        public DateTime SellStartDate { get; set; }

        ///<summary>Date the product was no longer available for sale.</summary>
        ///<remarks></remarks>
        [Column("SellEndDate", Order = 21)]
        public DateTime? SellEndDate { get; set; }

        ///<summary>Date the product was discontinued.</summary>
        ///<remarks></remarks>
        [Column("DiscontinuedDate", Order = 22)]
        public DateTime? DiscontinuedDate { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 23)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 24)]
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
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; }

        public virtual ProductModel ProductModel { get; set; }

        public virtual ProductSubcategory ProductSubcategory { get; set; }

        public virtual UnitMeasure SizeUnitMeasure { get; set; }

        public virtual UnitMeasure WeightUnitMeasure { get; set; }

    }
}
