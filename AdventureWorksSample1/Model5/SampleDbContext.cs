﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    public class SampleDbContext : DbContext{
        public SampleDbContext()
            : base("name=AdventureWorks")
        {
            Database.SetInitializer<SampleDbContext>(null);
            //Database.Log = x => Console.Out.WriteLine(x);
        }
        public virtual DbSet<AWBuildVersion> AWBuildVersion { get; set; }
        public virtual DbSet<DatabaseLog> DatabaseLog { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<DemoSalesOrderDetailSeed> DemoSalesOrderDetailSeed { get; set; }
        public virtual DbSet<DemoSalesOrderHeaderSeed> DemoSalesOrderHeaderSeed { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Employee_Temporal> Employee_Temporal { get; set; }
        public virtual DbSet<Employee_Temporal_History> Employee_Temporal_History { get; set; }
        public virtual DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
        public virtual DbSet<EmployeePayHistory> EmployeePayHistory { get; set; }
        public virtual DbSet<JobCandidate> JobCandidate { get; set; }
        public virtual DbSet<Shift> Shift { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressType> AddressType { get; set; }
        public virtual DbSet<BusinessEntity> BusinessEntity { get; set; }
        public virtual DbSet<BusinessEntityAddress> BusinessEntityAddress { get; set; }
        public virtual DbSet<BusinessEntityContact> BusinessEntityContact { get; set; }
        public virtual DbSet<ContactType> ContactType { get; set; }
        public virtual DbSet<CountryRegion> CountryRegion { get; set; }
        public virtual DbSet<EmailAddress> EmailAddress { get; set; }
        public virtual DbSet<Password> Password { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Person_json> Person_json { get; set; }
        public virtual DbSet<Person_Temporal> Person_Temporal { get; set; }
        public virtual DbSet<Person_Temporal_History> Person_Temporal_History { get; set; }
        public virtual DbSet<PersonPhone> PersonPhone { get; set; }
        public virtual DbSet<PhoneNumberType> PhoneNumberType { get; set; }
        public virtual DbSet<StateProvince> StateProvince { get; set; }
        public virtual DbSet<BillOfMaterials> BillOfMaterials { get; set; }
        public virtual DbSet<Culture> Culture { get; set; }
        public virtual DbSet<Illustration> Illustration { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Product_inmem> Product_inmem { get; set; }
        public virtual DbSet<Product_ondisk> Product_ondisk { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<ProductCostHistory> ProductCostHistory { get; set; }
        public virtual DbSet<ProductDescription> ProductDescription { get; set; }
        public virtual DbSet<ProductInventory> ProductInventory { get; set; }
        public virtual DbSet<ProductListPriceHistory> ProductListPriceHistory { get; set; }
        public virtual DbSet<ProductModel> ProductModel { get; set; }
        public virtual DbSet<ProductModelIllustration> ProductModelIllustration { get; set; }
        public virtual DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; }
        public virtual DbSet<ProductPhoto> ProductPhoto { get; set; }
        public virtual DbSet<ProductProductPhoto> ProductProductPhoto { get; set; }
        public virtual DbSet<ProductReview> ProductReview { get; set; }
        public virtual DbSet<ProductSubcategory> ProductSubcategory { get; set; }
        public virtual DbSet<ScrapReason> ScrapReason { get; set; }
        public virtual DbSet<TransactionHistory> TransactionHistory { get; set; }
        public virtual DbSet<TransactionHistoryArchive> TransactionHistoryArchive { get; set; }
        public virtual DbSet<UnitMeasure> UnitMeasure { get; set; }
        public virtual DbSet<WorkOrder> WorkOrder { get; set; }
        public virtual DbSet<WorkOrderRouting> WorkOrderRouting { get; set; }
        public virtual DbSet<ProductVendor> ProductVendor { get; set; }
        public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }
        public virtual DbSet<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }
        public virtual DbSet<ShipMethod> ShipMethod { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<CountryRegionCurrency> CountryRegionCurrency { get; set; }
        public virtual DbSet<CreditCard> CreditCard { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<CurrencyRate> CurrencyRate { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerPII> CustomerPII { get; set; }
        public virtual DbSet<OrderTracking> OrderTracking { get; set; }
        public virtual DbSet<PersonCreditCard> PersonCreditCard { get; set; }
        public virtual DbSet<SalesOrder_json> SalesOrder_json { get; set; }
        public virtual DbSet<SalesOrderDetail> SalesOrderDetail { get; set; }
        public virtual DbSet<SalesOrderDetail_inmem> SalesOrderDetail_inmem { get; set; }
        public virtual DbSet<SalesOrderDetail_ondisk> SalesOrderDetail_ondisk { get; set; }
        public virtual DbSet<SalesOrderHeader> SalesOrderHeader { get; set; }
        public virtual DbSet<SalesOrderHeader_inmem> SalesOrderHeader_inmem { get; set; }
        public virtual DbSet<SalesOrderHeader_ondisk> SalesOrderHeader_ondisk { get; set; }
        public virtual DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get; set; }
        public virtual DbSet<SalesPerson> SalesPerson { get; set; }
        public virtual DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistory { get; set; }
        public virtual DbSet<SalesReason> SalesReason { get; set; }
        public virtual DbSet<SalesTaxRate> SalesTaxRate { get; set; }
        public virtual DbSet<SalesTerritory> SalesTerritory { get; set; }
        public virtual DbSet<SalesTerritoryHistory> SalesTerritoryHistory { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        public virtual DbSet<SpecialOffer> SpecialOffer { get; set; }
        public virtual DbSet<SpecialOffer_inmem> SpecialOffer_inmem { get; set; }
        public virtual DbSet<SpecialOffer_ondisk> SpecialOffer_ondisk { get; set; }
        public virtual DbSet<SpecialOfferProduct> SpecialOfferProduct { get; set; }
        public virtual DbSet<SpecialOfferProduct_inmem> SpecialOfferProduct_inmem { get; set; }
        public virtual DbSet<SpecialOfferProduct_ondisk> SpecialOfferProduct_ondisk { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<TrackingEvent> TrackingEvent { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Department>()
                .HasMany(e => e.EmployeeDepartmentHistories)
                .WithRequired(e => e.Department)
                .HasForeignKey(e => e.DepartmentID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeDepartmentHistories)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.BusinessEntityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeePayHistories)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.BusinessEntityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.JobCandidates)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.BusinessEntityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.PurchaseOrderHeaders)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.EmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.SalesPerson)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.MaritalStatus)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<Employee_Temporal>()
                .Property(e => e.MaritalStatus)
                .IsFixedLength();

            modelBuilder.Entity<Employee_Temporal>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<Employee_Temporal_History>()
                .Property(e => e.MaritalStatus)
                .IsFixedLength();

            modelBuilder.Entity<Employee_Temporal_History>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<EmployeePayHistory>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Shift>()
                .HasMany(e => e.EmployeeDepartmentHistories)
                .WithRequired(e => e.Shift)
                .HasForeignKey(e => e.ShiftID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.BusinessEntityAddresses)
                .WithRequired(e => e.Address)
                .HasForeignKey(e => e.AddressID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.SalesOrderHeaders)
                .WithRequired(e => e.Address)
                .HasForeignKey(e => e.BillToAddressID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.SalesOrderHeaders1)
                .WithRequired(e => e.Address1)
                .HasForeignKey(e => e.ShipToAddressID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AddressType>()
                .HasMany(e => e.BusinessEntityAddresses)
                .WithRequired(e => e.AddressType)
                .HasForeignKey(e => e.AddressTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.BusinessEntityAddresses)
                .WithRequired(e => e.BusinessEntity)
                .HasForeignKey(e => e.BusinessEntityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.BusinessEntityContacts)
                .WithRequired(e => e.BusinessEntity)
                .HasForeignKey(e => e.BusinessEntityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessEntity>()
                .HasOptional(e => e.Person)
                .WithRequired(e => e.BusinessEntity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessEntity>()
                .HasOptional(e => e.Vendor)
                .WithRequired(e => e.BusinessEntity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessEntity>()
                .HasOptional(e => e.Store)
                .WithRequired(e => e.BusinessEntity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContactType>()
                .HasMany(e => e.BusinessEntityContacts)
                .WithRequired(e => e.ContactType)
                .HasForeignKey(e => e.ContactTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryRegion>()
                .HasMany(e => e.StateProvinces)
                .WithRequired(e => e.CountryRegion)
                .HasForeignKey(e => e.CountryRegionCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryRegion>()
                .HasMany(e => e.CountryRegionCurrencies)
                .WithRequired(e => e.CountryRegion)
                .HasForeignKey(e => e.CountryRegionCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryRegion>()
                .HasMany(e => e.SalesTerritories)
                .WithRequired(e => e.CountryRegion)
                .HasForeignKey(e => e.CountryRegionCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Password>()
                .Property(e => e.PasswordHash)
                .IsUnicode(false);

            modelBuilder.Entity<Password>()
                .Property(e => e.PasswordSalt)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .HasOptional(e => e.Employee)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.BusinessEntityContacts)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.PersonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.EmailAddresses)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.BusinessEntityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasOptional(e => e.Password)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonPhones)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.BusinessEntityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.Person)
                .HasForeignKey(e => e.PersonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonCreditCards)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.BusinessEntityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.PersonType)
                .IsFixedLength();

            modelBuilder.Entity<Person_json>()
                .Property(e => e.PersonType)
                .IsFixedLength();

            modelBuilder.Entity<Person_Temporal>()
                .Property(e => e.PersonType)
                .IsFixedLength();

            modelBuilder.Entity<Person_Temporal_History>()
                .Property(e => e.PersonType)
                .IsFixedLength();

            modelBuilder.Entity<PhoneNumberType>()
                .HasMany(e => e.PersonPhones)
                .WithRequired(e => e.PhoneNumberType)
                .HasForeignKey(e => e.PhoneNumberTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StateProvince>()
                .HasMany(e => e.Addresses)
                .WithRequired(e => e.StateProvince)
                .HasForeignKey(e => e.StateProvinceID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StateProvince>()
                .HasMany(e => e.SalesTaxRates)
                .WithRequired(e => e.StateProvince)
                .HasForeignKey(e => e.StateProvinceID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StateProvince>()
                .Property(e => e.StateProvinceCode)
                .IsFixedLength();

            modelBuilder.Entity<BillOfMaterials>()
                .Property(e => e.UnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<BillOfMaterials>()
                .Property(e => e.PerAssemblyQty)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Culture>()
                .HasMany(e => e.ProductModelProductDescriptionCultures)
                .WithRequired(e => e.Culture)
                .HasForeignKey(e => e.CultureID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Culture>()
                .Property(e => e.CultureID)
                .IsFixedLength();

            modelBuilder.Entity<Illustration>()
                .HasMany(e => e.ProductModelIllustrations)
                .WithRequired(e => e.Illustration)
                .HasForeignKey(e => e.IllustrationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.ProductInventories)
                .WithRequired(e => e.Location)
                .HasForeignKey(e => e.LocationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.WorkOrderRoutings)
                .WithRequired(e => e.Location)
                .HasForeignKey(e => e.LocationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.Availability)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.BillOfMaterials)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ComponentID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.BillOfMaterials1)
                .WithOptional(e => e.Product1)
                .HasForeignKey(e => e.ProductAssemblyID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductCostHistories)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductInventories)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductListPriceHistories)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductProductPhotos)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductReviews)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.TransactionHistories)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.WorkOrders)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductVendors)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.PurchaseOrderDetails)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ShoppingCartItems)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.SpecialOfferProducts)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.StandardCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.ListPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.SizeUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.WeightUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Weight)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductLine)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Class)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Style)
                .IsFixedLength();

            modelBuilder.Entity<Product_inmem>()
                .HasMany(e => e.SpecialOfferProduct_inmems)
                .WithRequired(e => e.Product_inmem)
                .HasForeignKey(e => e.ProductID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product_inmem>()
                .Property(e => e.StandardCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product_inmem>()
                .Property(e => e.ListPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product_inmem>()
                .Property(e => e.SizeUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<Product_inmem>()
                .Property(e => e.WeightUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<Product_inmem>()
                .Property(e => e.Weight)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Product_inmem>()
                .Property(e => e.ProductLine)
                .IsFixedLength();

            modelBuilder.Entity<Product_inmem>()
                .Property(e => e.Class)
                .IsFixedLength();

            modelBuilder.Entity<Product_inmem>()
                .Property(e => e.Style)
                .IsFixedLength();

            modelBuilder.Entity<Product_ondisk>()
                .HasMany(e => e.SpecialOfferProduct_ondisks)
                .WithRequired(e => e.Product_ondisk)
                .HasForeignKey(e => e.ProductID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product_ondisk>()
                .Property(e => e.StandardCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product_ondisk>()
                .Property(e => e.ListPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product_ondisk>()
                .Property(e => e.SizeUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<Product_ondisk>()
                .Property(e => e.WeightUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<Product_ondisk>()
                .Property(e => e.Weight)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Product_ondisk>()
                .Property(e => e.ProductLine)
                .IsFixedLength();

            modelBuilder.Entity<Product_ondisk>()
                .Property(e => e.Class)
                .IsFixedLength();

            modelBuilder.Entity<Product_ondisk>()
                .Property(e => e.Style)
                .IsFixedLength();

            modelBuilder.Entity<ProductCategory>()
                .HasMany(e => e.ProductSubcategories)
                .WithRequired(e => e.ProductCategory)
                .HasForeignKey(e => e.ProductCategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductCostHistory>()
                .Property(e => e.StandardCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductDescription>()
                .HasMany(e => e.ProductModelProductDescriptionCultures)
                .WithRequired(e => e.ProductDescription)
                .HasForeignKey(e => e.ProductDescriptionID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductListPriceHistory>()
                .Property(e => e.ListPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductModel>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.ProductModel)
                .HasForeignKey(e => e.ProductModelID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductModel>()
                .HasMany(e => e.ProductModelIllustrations)
                .WithRequired(e => e.ProductModel)
                .HasForeignKey(e => e.ProductModelID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductModel>()
                .HasMany(e => e.ProductModelProductDescriptionCultures)
                .WithRequired(e => e.ProductModel)
                .HasForeignKey(e => e.ProductModelID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductModelProductDescriptionCulture>()
                .Property(e => e.CultureID)
                .IsFixedLength();

            modelBuilder.Entity<ProductPhoto>()
                .HasMany(e => e.ProductProductPhotos)
                .WithRequired(e => e.ProductPhoto)
                .HasForeignKey(e => e.ProductPhotoID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductSubcategory>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.ProductSubcategory)
                .HasForeignKey(e => e.ProductSubcategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ScrapReason>()
                .HasMany(e => e.WorkOrders)
                .WithOptional(e => e.ScrapReason)
                .HasForeignKey(e => e.ScrapReasonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransactionHistory>()
                .Property(e => e.TransactionType)
                .IsFixedLength();

            modelBuilder.Entity<TransactionHistory>()
                .Property(e => e.ActualCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TransactionHistoryArchive>()
                .Property(e => e.TransactionType)
                .IsFixedLength();

            modelBuilder.Entity<TransactionHistoryArchive>()
                .Property(e => e.ActualCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UnitMeasure>()
                .HasMany(e => e.BillOfMaterials)
                .WithRequired(e => e.UnitMeasure)
                .HasForeignKey(e => e.UnitMeasureCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UnitMeasure>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.UnitMeasure)
                .HasForeignKey(e => e.SizeUnitMeasureCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UnitMeasure>()
                .HasMany(e => e.Products1)
                .WithOptional(e => e.UnitMeasure1)
                .HasForeignKey(e => e.WeightUnitMeasureCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UnitMeasure>()
                .HasMany(e => e.ProductVendors)
                .WithRequired(e => e.UnitMeasure)
                .HasForeignKey(e => e.UnitMeasureCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UnitMeasure>()
                .Property(e => e.UnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<WorkOrder>()
                .HasMany(e => e.WorkOrderRoutings)
                .WithRequired(e => e.WorkOrder)
                .HasForeignKey(e => e.WorkOrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WorkOrderRouting>()
                .Property(e => e.ActualResourceHrs)
                .HasPrecision(9, 4);

            modelBuilder.Entity<WorkOrderRouting>()
                .Property(e => e.PlannedCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WorkOrderRouting>()
                .Property(e => e.ActualCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductVendor>()
                .Property(e => e.StandardPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductVendor>()
                .Property(e => e.LastReceiptCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductVendor>()
                .Property(e => e.UnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<PurchaseOrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseOrderDetail>()
                .Property(e => e.LineTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseOrderDetail>()
                .Property(e => e.ReceivedQty)
                .HasPrecision(8, 2);

            modelBuilder.Entity<PurchaseOrderDetail>()
                .Property(e => e.RejectedQty)
                .HasPrecision(8, 2);

            modelBuilder.Entity<PurchaseOrderDetail>()
                .Property(e => e.StockedQty)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PurchaseOrderHeader>()
                .HasMany(e => e.PurchaseOrderDetails)
                .WithRequired(e => e.PurchaseOrderHeader)
                .HasForeignKey(e => e.PurchaseOrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PurchaseOrderHeader>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseOrderHeader>()
                .Property(e => e.TaxAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseOrderHeader>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseOrderHeader>()
                .Property(e => e.TotalDue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShipMethod>()
                .HasMany(e => e.PurchaseOrderHeaders)
                .WithRequired(e => e.ShipMethod)
                .HasForeignKey(e => e.ShipMethodID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShipMethod>()
                .HasMany(e => e.SalesOrderHeaders)
                .WithRequired(e => e.ShipMethod)
                .HasForeignKey(e => e.ShipMethodID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShipMethod>()
                .Property(e => e.ShipBase)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShipMethod>()
                .Property(e => e.ShipRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.ProductVendors)
                .WithRequired(e => e.Vendor)
                .HasForeignKey(e => e.BusinessEntityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.PurchaseOrderHeaders)
                .WithRequired(e => e.Vendor)
                .HasForeignKey(e => e.VendorID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryRegionCurrency>()
                .Property(e => e.CurrencyCode)
                .IsFixedLength();

            modelBuilder.Entity<CreditCard>()
                .HasMany(e => e.PersonCreditCards)
                .WithRequired(e => e.CreditCard)
                .HasForeignKey(e => e.CreditCardID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CreditCard>()
                .HasMany(e => e.SalesOrderHeaders)
                .WithOptional(e => e.CreditCard)
                .HasForeignKey(e => e.CreditCardID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.CountryRegionCurrencies)
                .WithRequired(e => e.Currency)
                .HasForeignKey(e => e.CurrencyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.CurrencyRates)
                .WithRequired(e => e.Currency)
                .HasForeignKey(e => e.FromCurrencyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.CurrencyRates1)
                .WithRequired(e => e.Currency1)
                .HasForeignKey(e => e.ToCurrencyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>()
                .Property(e => e.CurrencyCode)
                .IsFixedLength();

            modelBuilder.Entity<CurrencyRate>()
                .HasMany(e => e.SalesOrderHeaders)
                .WithOptional(e => e.CurrencyRate)
                .HasForeignKey(e => e.CurrencyRateID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CurrencyRate>()
                .Property(e => e.FromCurrencyCode)
                .IsFixedLength();

            modelBuilder.Entity<CurrencyRate>()
                .Property(e => e.ToCurrencyCode)
                .IsFixedLength();

            modelBuilder.Entity<CurrencyRate>()
                .Property(e => e.AverageRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CurrencyRate>()
                .Property(e => e.EndOfDayRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.SalesOrderHeaders)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.CustomerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<SalesOrder_json>()
                .Property(e => e.CreditCardApprovalCode)
                .IsUnicode(false);

            modelBuilder.Entity<SalesOrder_json>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrder_json>()
                .Property(e => e.TaxAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrder_json>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrder_json>()
                .Property(e => e.TotalDue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetail>()
                .Property(e => e.UnitPriceDiscount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetail_inmem>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetail_inmem>()
                .Property(e => e.UnitPriceDiscount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetail_ondisk>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetail_ondisk>()
                .Property(e => e.UnitPriceDiscount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader>()
                .HasMany(e => e.SalesOrderDetails)
                .WithRequired(e => e.SalesOrderHeader)
                .HasForeignKey(e => e.SalesOrderID);

            modelBuilder.Entity<SalesOrderHeader>()
                .HasMany(e => e.SalesOrderHeaderSalesReasons)
                .WithRequired(e => e.SalesOrderHeader)
                .HasForeignKey(e => e.SalesOrderID);

            modelBuilder.Entity<SalesOrderHeader>()
                .Property(e => e.CreditCardApprovalCode)
                .IsUnicode(false);

            modelBuilder.Entity<SalesOrderHeader>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader>()
                .Property(e => e.TaxAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader>()
                .Property(e => e.TotalDue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader_inmem>()
                .HasMany(e => e.SalesOrderDetail_inmems)
                .WithRequired(e => e.SalesOrderHeader_inmem)
                .HasForeignKey(e => e.SalesOrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesOrderHeader_inmem>()
                .Property(e => e.CreditCardApprovalCode)
                .IsUnicode(false);

            modelBuilder.Entity<SalesOrderHeader_inmem>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader_inmem>()
                .Property(e => e.TaxAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader_inmem>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader_ondisk>()
                .HasMany(e => e.SalesOrderDetail_ondisks)
                .WithRequired(e => e.SalesOrderHeader_ondisk)
                .HasForeignKey(e => e.SalesOrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesOrderHeader_ondisk>()
                .Property(e => e.CreditCardApprovalCode)
                .IsUnicode(false);

            modelBuilder.Entity<SalesOrderHeader_ondisk>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader_ondisk>()
                .Property(e => e.TaxAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader_ondisk>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesPerson>()
                .HasMany(e => e.SalesOrderHeaders)
                .WithOptional(e => e.SalesPerson)
                .HasForeignKey(e => e.SalesPersonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesPerson>()
                .HasMany(e => e.SalesPersonQuotaHistories)
                .WithRequired(e => e.SalesPerson)
                .HasForeignKey(e => e.BusinessEntityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesPerson>()
                .HasMany(e => e.SalesTerritoryHistories)
                .WithRequired(e => e.SalesPerson)
                .HasForeignKey(e => e.BusinessEntityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesPerson>()
                .HasMany(e => e.Stores)
                .WithOptional(e => e.SalesPerson)
                .HasForeignKey(e => e.SalesPersonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesPerson>()
                .Property(e => e.SalesQuota)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesPerson>()
                .Property(e => e.Bonus)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesPerson>()
                .Property(e => e.SalesYTD)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesPerson>()
                .Property(e => e.SalesLastYear)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesPersonQuotaHistory>()
                .Property(e => e.SalesQuota)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesReason>()
                .HasMany(e => e.SalesOrderHeaderSalesReasons)
                .WithRequired(e => e.SalesReason)
                .HasForeignKey(e => e.SalesReasonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesTerritory>()
                .HasMany(e => e.StateProvinces)
                .WithRequired(e => e.SalesTerritory)
                .HasForeignKey(e => e.TerritoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesTerritory>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.SalesTerritory)
                .HasForeignKey(e => e.TerritoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesTerritory>()
                .HasMany(e => e.SalesOrderHeaders)
                .WithOptional(e => e.SalesTerritory)
                .HasForeignKey(e => e.TerritoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesTerritory>()
                .HasMany(e => e.SalesPersons)
                .WithOptional(e => e.SalesTerritory)
                .HasForeignKey(e => e.TerritoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesTerritory>()
                .HasMany(e => e.SalesTerritoryHistories)
                .WithRequired(e => e.SalesTerritory)
                .HasForeignKey(e => e.TerritoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesTerritory>()
                .Property(e => e.SalesYTD)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesTerritory>()
                .Property(e => e.SalesLastYear)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesTerritory>()
                .Property(e => e.CostYTD)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesTerritory>()
                .Property(e => e.CostLastYear)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SpecialOffer>()
                .HasMany(e => e.SpecialOfferProducts)
                .WithRequired(e => e.SpecialOffer)
                .HasForeignKey(e => e.SpecialOfferID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecialOffer_inmem>()
                .HasMany(e => e.SpecialOfferProduct_inmems)
                .WithRequired(e => e.SpecialOffer_inmem)
                .HasForeignKey(e => e.SpecialOfferID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecialOffer_ondisk>()
                .HasMany(e => e.SpecialOfferProduct_ondisks)
                .WithRequired(e => e.SpecialOffer_ondisk)
                .HasForeignKey(e => e.SpecialOfferID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecialOfferProduct>()
                .HasMany(e => e.SalesOrderDetails)
                .WithRequired(e => e.SpecialOfferProduct)
                .HasForeignKey(e => new { 
                    e.SpecialOfferID
,                    e.ProductID
                
                 })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecialOfferProduct_inmem>()
                .HasMany(e => e.SalesOrderDetail_inmems)
                .WithRequired(e => e.SpecialOfferProduct_inmem)
                .HasForeignKey(e => new { 
                    e.SpecialOfferID
,                    e.ProductID
                
                 })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecialOfferProduct_ondisk>()
                .HasMany(e => e.SalesOrderDetail_ondisks)
                .WithRequired(e => e.SpecialOfferProduct_ondisk)
                .HasForeignKey(e => new { 
                    e.SpecialOfferID
,                    e.ProductID
                
                 })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.Store)
                .HasForeignKey(e => e.StoreID)
                .WillCascadeOnDelete(false);

        }
    }
}
