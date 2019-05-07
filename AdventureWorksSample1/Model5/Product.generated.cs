using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.Product")]
    public partial class Product
    {
        public Product()
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
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            BillOfMaterials = new HashSet<BillOfMaterials>();
            BillOfMaterials1 = new HashSet<BillOfMaterials>();
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

        [StringLength(3)]
        public string SizeUnitMeasureCode { get; set; }

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

        public int? ProductSubcategoryID { get; set; }

        public int? ProductModelID { get; set; }

        [Column("SellStartDate", Order = 20, TypeName = "datetime")]
        public DateTime SellStartDate { get; set; }

        [Column("SellEndDate", Order = 21, TypeName = "datetime")]
        public DateTime? SellEndDate { get; set; }

        [Column("DiscontinuedDate", Order = 22, TypeName = "datetime")]
        public DateTime? DiscontinuedDate { get; set; }

        [Column("rowguid", Order = 23, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 24, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//BillOfMaterials Product
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillOfMaterials> BillOfMaterials { get; set; }

//BillOfMaterials Product
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillOfMaterials> BillOfMaterials1 { get; set; }

//ProductCostHistory Product
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductCostHistory> ProductCostHistories { get; set; }

//ProductDocument Product
            //ProductInventory Product
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }

//ProductListPriceHistory Product
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductListPriceHistory> ProductListPriceHistories { get; set; }

//ProductProductPhoto Product
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductProductPhoto> ProductProductPhotos { get; set; }

//ProductReview Product
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductReview> ProductReviews { get; set; }

//TransactionHistory Product
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }

//WorkOrder Product
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }

//ProductVendor Product
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }

//PurchaseOrderDetail Product
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }

//ShoppingCartItem Product
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }

//SpecialOfferProduct Product
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; }

        public virtual ProductModel ProductModel { get; set; }

        public virtual ProductSubcategory ProductSubcategory { get; set; }

        public virtual UnitMeasure UnitMeasure { get; set; }

        public virtual UnitMeasure UnitMeasure1 { get; set; }

    }
}
