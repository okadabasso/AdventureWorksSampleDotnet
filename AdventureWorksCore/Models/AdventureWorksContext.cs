using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace AdventureWorksCore.Models
{
    public class AdventureWorksContext : DbContext{
        public AdventureWorksContext()
            : base()
        {
            //Database.Log = x => Console.Out.WriteLine(x);
        }
        public DbSet<AwBuildVersion> AwBuildVersions { get; set; }
        public DbSet<DatabaseLog> DatabaseLogs { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<DemoSalesOrderDetailSeed> DemoSalesOrderDetailSeeds { get; set; }
        public DbSet<DemoSalesOrderHeaderSeed> DemoSalesOrderHeaderSeeds { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeTemporal> EmployeeTemporals { get; set; }
        public DbSet<EmployeeTemporalHistory> EmployeeTemporalHistories { get; set; }
        public DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
        public DbSet<EmployeePayHistory> EmployeePayHistories { get; set; }
        public DbSet<JobCandidate> JobCandidates { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<BusinessEntity> BusinessEntities { get; set; }
        public DbSet<BusinessEntityAddress> BusinessEntityAddresses { get; set; }
        public DbSet<BusinessEntityContact> BusinessEntityContacts { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<CountryRegion> CountryRegions { get; set; }
        public DbSet<EmailAddress> EmailAddresses { get; set; }
        public DbSet<Password> Passwords { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonJson> PersonJsons { get; set; }
        public DbSet<PersonTemporal> PersonTemporals { get; set; }
        public DbSet<PersonTemporalHistory> PersonTemporalHistories { get; set; }
        public DbSet<PersonPhone> PersonPhones { get; set; }
        public DbSet<PhoneNumberType> PhoneNumberTypes { get; set; }
        public DbSet<StateProvince> StateProvinces { get; set; }
        public DbSet<BillOfMaterials> BillOfMaterials { get; set; }
        public DbSet<Culture> Cultures { get; set; }
        public DbSet<Illustration> Illustrations { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInmem> ProductInmems { get; set; }
        public DbSet<ProductOndisk> ProductOndisks { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductCostHistory> ProductCostHistories { get; set; }
        public DbSet<ProductDescription> ProductDescriptions { get; set; }
        public DbSet<ProductInventory> ProductInventories { get; set; }
        public DbSet<ProductListPriceHistory> ProductListPriceHistories { get; set; }
        public DbSet<ProductModel> ProductModels { get; set; }
        public DbSet<ProductModelIllustration> ProductModelIllustrations { get; set; }
        public DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<ProductProductPhoto> ProductProductPhotos { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<ProductSubcategory> ProductSubcategories { get; set; }
        public DbSet<ScrapReason> ScrapReasons { get; set; }
        public DbSet<TransactionHistory> TransactionHistories { get; set; }
        public DbSet<TransactionHistoryArchive> TransactionHistoryArchives { get; set; }
        public DbSet<UnitMeasure> UnitMeasures { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
        public DbSet<WorkOrderRouting> WorkOrderRoutings { get; set; }
        public DbSet<ProductVendor> ProductVendors { get; set; }
        public DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public DbSet<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
        public DbSet<ShipMethod> ShipMethods { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<CountryRegionCurrency> CountryRegionCurrencies { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyRate> CurrencyRates { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerPii> CustomerPiis { get; set; }
        public DbSet<OrderTracking> OrderTrackings { get; set; }
        public DbSet<PersonCreditCard> PersonCreditCards { get; set; }
        public DbSet<SalesOrderJson> SalesOrderJsons { get; set; }
        public DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public DbSet<SalesOrderDetailInmem> SalesOrderDetailInmems { get; set; }
        public DbSet<SalesOrderDetailOndisk> SalesOrderDetailOndisks { get; set; }
        public DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public DbSet<SalesOrderHeaderInmem> SalesOrderHeaderInmems { get; set; }
        public DbSet<SalesOrderHeaderOndisk> SalesOrderHeaderOndisks { get; set; }
        public DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }
        public DbSet<SalesPerson> SalesPersons { get; set; }
        public DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }
        public DbSet<SalesReason> SalesReasons { get; set; }
        public DbSet<SalesTaxRate> SalesTaxRates { get; set; }
        public DbSet<SalesTerritory> SalesTerritories { get; set; }
        public DbSet<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<SpecialOffer> SpecialOffers { get; set; }
        public DbSet<SpecialOfferInmem> SpecialOfferInmems { get; set; }
        public DbSet<SpecialOfferOndisk> SpecialOfferOndisks { get; set; }
        public DbSet<SpecialOfferProduct> SpecialOfferProducts { get; set; }
        public DbSet<SpecialOfferProductInmem> SpecialOfferProductInmems { get; set; }
        public DbSet<SpecialOfferProductOndisk> SpecialOfferProductOndisks { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<TrackingEvent> TrackingEvents { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(@"data source=localhost\SQLEXPRESS;initial catalog=AdventureWorks2016;integrated security=True;MultipleActiveResultSets=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AwBuildVersion>()
                .HasKey(e => e.SystemInformationId);

            modelBuilder.Entity<DatabaseLog>()
                .HasKey(e => e.DatabaseLogId);

            modelBuilder.Entity<ErrorLog>()
                .HasKey(e => e.ErrorLogId);

            modelBuilder.Entity<DemoSalesOrderDetailSeed>()
                .HasKey(e => e.LocalId);

            modelBuilder.Entity<DemoSalesOrderHeaderSeed>()
                .HasKey(e => e.LocalId);

            modelBuilder.Entity<Department>()
                .HasKey(e => e.DepartmentId);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.EmployeeDepartmentHistories)
                .WithOne(e => e.Department)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<Employee>()
                .HasKey(e => e.BusinessEntityId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeDepartmentHistories)
                .WithOne(e => e.Employee)
                .HasForeignKey(e => e.BusinessEntityId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeePayHistories)
                .WithOne(e => e.Employee)
                .HasForeignKey(e => e.BusinessEntityId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.JobCandidates)
                .WithOne(e => e.Employee)
                .HasForeignKey(e => e.BusinessEntityId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.PurchaseOrderHeaders)
                .WithOne(e => e.Employee)
                .HasForeignKey(e => e.EmployeeId);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.SalesPerson)
                .WithOne(e => e.Employee)
                .HasForeignKey<SalesPerson>(e => e.BusinessEntityId);

            modelBuilder.Entity<Employee>()
                .Property(e => e.MaritalStatus)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<EmployeeTemporal>()
                .HasKey(e => e.BusinessEntityId);

            modelBuilder.Entity<EmployeeTemporal>()
                .Property(e => e.MaritalStatus)
                .IsFixedLength();

            modelBuilder.Entity<EmployeeTemporal>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<EmployeeTemporalHistory>()
                .Property(e => e.MaritalStatus)
                .IsFixedLength();

            modelBuilder.Entity<EmployeeTemporalHistory>()
                .Property(e => e.Gender)
                .IsFixedLength();


            modelBuilder.Entity<EmployeeDepartmentHistory>()
                .HasKey(e => new { 
                    e.BusinessEntityId, 
                    e.StartDate, 
                    e.DepartmentId, 
                    e.ShiftId});


            modelBuilder.Entity<EmployeePayHistory>()
                .HasKey(e => new { 
                    e.BusinessEntityId, 
                    e.RateChangeDate});

            modelBuilder.Entity<JobCandidate>()
                .HasKey(e => e.JobCandidateId);

            modelBuilder.Entity<Shift>()
                .HasKey(e => e.ShiftId);

            modelBuilder.Entity<Shift>()
                .HasMany(e => e.EmployeeDepartmentHistories)
                .WithOne(e => e.Shift)
                .HasForeignKey(e => e.ShiftId);

            modelBuilder.Entity<Address>()
                .HasKey(e => e.AddressId);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.BusinessEntityAddresses)
                .WithOne(e => e.Address)
                .HasForeignKey(e => e.AddressId);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.BillToSalesOrderHeaders)
                .WithOne(e => e.BillToAddress)
                .HasForeignKey(e => e.BillToAddressId);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.ShipToSalesOrderHeaders)
                .WithOne(e => e.ShipToAddress)
                .HasForeignKey(e => e.ShipToAddressId);

            modelBuilder.Entity<AddressType>()
                .HasKey(e => e.AddressTypeId);

            modelBuilder.Entity<AddressType>()
                .HasMany(e => e.BusinessEntityAddresses)
                .WithOne(e => e.AddressType)
                .HasForeignKey(e => e.AddressTypeId);

            modelBuilder.Entity<BusinessEntity>()
                .HasKey(e => e.BusinessEntityId);

            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.BusinessEntityAddresses)
                .WithOne(e => e.BusinessEntity)
                .HasForeignKey(e => e.BusinessEntityId);

            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.BusinessEntityContacts)
                .WithOne(e => e.BusinessEntity)
                .HasForeignKey(e => e.BusinessEntityId);

            modelBuilder.Entity<BusinessEntity>()
                .HasOne(e => e.Person)
                .WithOne(e => e.BusinessEntity)
                .HasForeignKey<Person>(e => e.BusinessEntityId);

            modelBuilder.Entity<BusinessEntity>()
                .HasOne(e => e.Store)
                .WithOne(e => e.BusinessEntity)
                .HasForeignKey<Store>(e => e.BusinessEntityId);

            modelBuilder.Entity<BusinessEntity>()
                .HasOne(e => e.Vendor)
                .WithOne(e => e.BusinessEntity)
                .HasForeignKey<Vendor>(e => e.BusinessEntityId);


            modelBuilder.Entity<BusinessEntityAddress>()
                .HasKey(e => new { 
                    e.BusinessEntityId, 
                    e.AddressId, 
                    e.AddressTypeId});


            modelBuilder.Entity<BusinessEntityContact>()
                .HasKey(e => new { 
                    e.BusinessEntityId, 
                    e.PersonId, 
                    e.ContactTypeId});

            modelBuilder.Entity<ContactType>()
                .HasKey(e => e.ContactTypeId);

            modelBuilder.Entity<ContactType>()
                .HasMany(e => e.BusinessEntityContacts)
                .WithOne(e => e.ContactType)
                .HasForeignKey(e => e.ContactTypeId);

            modelBuilder.Entity<CountryRegion>()
                .HasKey(e => e.CountryRegionCode);

            modelBuilder.Entity<CountryRegion>()
                .HasMany(e => e.CountryRegionCurrencies)
                .WithOne(e => e.CountryRegion)
                .HasForeignKey(e => e.CountryRegionCode);

            modelBuilder.Entity<CountryRegion>()
                .HasMany(e => e.SalesTerritories)
                .WithOne(e => e.CountryRegion)
                .HasForeignKey(e => e.CountryRegionCode);

            modelBuilder.Entity<CountryRegion>()
                .HasMany(e => e.StateProvinces)
                .WithOne(e => e.CountryRegion)
                .HasForeignKey(e => e.CountryRegionCode);


            modelBuilder.Entity<EmailAddress>()
                .HasKey(e => new { 
                    e.BusinessEntityId, 
                    e.EmailAddressId});

            modelBuilder.Entity<Password>()
                .HasKey(e => e.BusinessEntityId);

            modelBuilder.Entity<Person>()
                .HasKey(e => e.BusinessEntityId);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.BusinessEntityContacts)
                .WithOne(e => e.Person)
                .HasForeignKey(e => e.PersonId);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Customers)
                .WithOne(e => e.Person)
                .HasForeignKey(e => e.PersonId);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.EmailAddresses)
                .WithOne(e => e.Person)
                .HasForeignKey(e => e.BusinessEntityId);

            modelBuilder.Entity<Person>()
                .HasOne(e => e.Employee)
                .WithOne(e => e.Person)
                .HasForeignKey<Employee>(e => e.BusinessEntityId);

            modelBuilder.Entity<Person>()
                .HasOne(e => e.Password)
                .WithOne(e => e.Person)
                .HasForeignKey<Password>(e => e.BusinessEntityId);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonCreditCards)
                .WithOne(e => e.Person)
                .HasForeignKey(e => e.BusinessEntityId);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonPhones)
                .WithOne(e => e.Person)
                .HasForeignKey(e => e.BusinessEntityId);

            modelBuilder.Entity<Person>()
                .Property(e => e.PersonType)
                .IsFixedLength();

            modelBuilder.Entity<PersonJson>()
                .HasKey(e => e.PersonId);

            modelBuilder.Entity<PersonJson>()
                .Property(e => e.PersonType)
                .IsFixedLength();

            modelBuilder.Entity<PersonTemporal>()
                .HasKey(e => e.BusinessEntityId);

            modelBuilder.Entity<PersonTemporal>()
                .Property(e => e.PersonType)
                .IsFixedLength();

            modelBuilder.Entity<PersonTemporalHistory>()
                .Property(e => e.PersonType)
                .IsFixedLength();


            modelBuilder.Entity<PersonPhone>()
                .HasKey(e => new { 
                    e.BusinessEntityId, 
                    e.PhoneNumber, 
                    e.PhoneNumberTypeId});

            modelBuilder.Entity<PhoneNumberType>()
                .HasKey(e => e.PhoneNumberTypeId);

            modelBuilder.Entity<PhoneNumberType>()
                .HasMany(e => e.PersonPhones)
                .WithOne(e => e.PhoneNumberType)
                .HasForeignKey(e => e.PhoneNumberTypeId);

            modelBuilder.Entity<StateProvince>()
                .HasKey(e => e.StateProvinceId);

            modelBuilder.Entity<StateProvince>()
                .HasMany(e => e.Addresses)
                .WithOne(e => e.StateProvince)
                .HasForeignKey(e => e.StateProvinceId);

            modelBuilder.Entity<StateProvince>()
                .HasMany(e => e.SalesTaxRates)
                .WithOne(e => e.StateProvince)
                .HasForeignKey(e => e.StateProvinceId);

            modelBuilder.Entity<StateProvince>()
                .Property(e => e.StateProvinceCode)
                .IsFixedLength();

            modelBuilder.Entity<BillOfMaterials>()
                .HasKey(e => e.BillOfMaterialsId);

            modelBuilder.Entity<BillOfMaterials>()
                .Property(e => e.UnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<Culture>()
                .HasKey(e => e.CultureId);

            modelBuilder.Entity<Culture>()
                .HasMany(e => e.ProductModelProductDescriptionCultures)
                .WithOne(e => e.Culture)
                .HasForeignKey(e => e.CultureId);

            modelBuilder.Entity<Culture>()
                .Property(e => e.CultureId)
                .IsFixedLength();

            modelBuilder.Entity<Illustration>()
                .HasKey(e => e.IllustrationId);

            modelBuilder.Entity<Illustration>()
                .HasMany(e => e.ProductModelIllustrations)
                .WithOne(e => e.Illustration)
                .HasForeignKey(e => e.IllustrationId);

            modelBuilder.Entity<Location>()
                .HasKey(e => e.LocationId);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.ProductInventories)
                .WithOne(e => e.Location)
                .HasForeignKey(e => e.LocationId);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.WorkOrderRoutings)
                .WithOne(e => e.Location)
                .HasForeignKey(e => e.LocationId);

            modelBuilder.Entity<Product>()
                .HasKey(e => e.ProductId);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ComponentBillOfMaterials)
                .WithOne(e => e.ComponentProduct)
                .HasForeignKey(e => e.ComponentId);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductAssemblyBillOfMaterials)
                .WithOne(e => e.ProductAssemblyProduct)
                .HasForeignKey(e => e.ProductAssemblyId);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductCostHistories)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductInventories)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductListPriceHistories)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductProductPhotos)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductReviews)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductVendors)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.PurchaseOrderDetails)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ShoppingCartItems)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.SpecialOfferProducts)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.TransactionHistories)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.WorkOrders)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<Product>()
                .Property(e => e.SizeUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.WeightUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductLine)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Class)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Style)
                .IsFixedLength();

            modelBuilder.Entity<ProductInmem>()
                .HasKey(e => e.ProductId);

            modelBuilder.Entity<ProductInmem>()
                .HasMany(e => e.SpecialOfferProductInmems)
                .WithOne(e => e.ProductInmem)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<ProductInmem>()
                .Property(e => e.SizeUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<ProductInmem>()
                .Property(e => e.WeightUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<ProductInmem>()
                .Property(e => e.ProductLine)
                .IsFixedLength();

            modelBuilder.Entity<ProductInmem>()
                .Property(e => e.Class)
                .IsFixedLength();

            modelBuilder.Entity<ProductInmem>()
                .Property(e => e.Style)
                .IsFixedLength();

            modelBuilder.Entity<ProductOndisk>()
                .HasKey(e => e.ProductId);

            modelBuilder.Entity<ProductOndisk>()
                .HasMany(e => e.SpecialOfferProductOndisks)
                .WithOne(e => e.ProductOndisk)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<ProductOndisk>()
                .Property(e => e.SizeUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<ProductOndisk>()
                .Property(e => e.WeightUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<ProductOndisk>()
                .Property(e => e.ProductLine)
                .IsFixedLength();

            modelBuilder.Entity<ProductOndisk>()
                .Property(e => e.Class)
                .IsFixedLength();

            modelBuilder.Entity<ProductOndisk>()
                .Property(e => e.Style)
                .IsFixedLength();

            modelBuilder.Entity<ProductCategory>()
                .HasKey(e => e.ProductCategoryId);

            modelBuilder.Entity<ProductCategory>()
                .HasMany(e => e.ProductSubcategories)
                .WithOne(e => e.ProductCategory)
                .HasForeignKey(e => e.ProductCategoryId);


            modelBuilder.Entity<ProductCostHistory>()
                .HasKey(e => new { 
                    e.ProductId, 
                    e.StartDate});

            modelBuilder.Entity<ProductDescription>()
                .HasKey(e => e.ProductDescriptionId);

            modelBuilder.Entity<ProductDescription>()
                .HasMany(e => e.ProductModelProductDescriptionCultures)
                .WithOne(e => e.ProductDescription)
                .HasForeignKey(e => e.ProductDescriptionId);


            modelBuilder.Entity<ProductInventory>()
                .HasKey(e => new { 
                    e.ProductId, 
                    e.LocationId});


            modelBuilder.Entity<ProductListPriceHistory>()
                .HasKey(e => new { 
                    e.ProductId, 
                    e.StartDate});

            modelBuilder.Entity<ProductModel>()
                .HasKey(e => e.ProductModelId);

            modelBuilder.Entity<ProductModel>()
                .HasMany(e => e.Products)
                .WithOne(e => e.ProductModel)
                .HasForeignKey(e => e.ProductModelId);

            modelBuilder.Entity<ProductModel>()
                .HasMany(e => e.ProductModelIllustrations)
                .WithOne(e => e.ProductModel)
                .HasForeignKey(e => e.ProductModelId);

            modelBuilder.Entity<ProductModel>()
                .HasMany(e => e.ProductModelProductDescriptionCultures)
                .WithOne(e => e.ProductModel)
                .HasForeignKey(e => e.ProductModelId);


            modelBuilder.Entity<ProductModelIllustration>()
                .HasKey(e => new { 
                    e.ProductModelId, 
                    e.IllustrationId});


            modelBuilder.Entity<ProductModelProductDescriptionCulture>()
                .HasKey(e => new { 
                    e.ProductModelId, 
                    e.ProductDescriptionId, 
                    e.CultureId});

            modelBuilder.Entity<ProductModelProductDescriptionCulture>()
                .Property(e => e.CultureId)
                .IsFixedLength();

            modelBuilder.Entity<ProductPhoto>()
                .HasKey(e => e.ProductPhotoId);

            modelBuilder.Entity<ProductPhoto>()
                .HasMany(e => e.ProductProductPhotos)
                .WithOne(e => e.ProductPhoto)
                .HasForeignKey(e => e.ProductPhotoId);


            modelBuilder.Entity<ProductProductPhoto>()
                .HasKey(e => new { 
                    e.ProductId, 
                    e.ProductPhotoId});

            modelBuilder.Entity<ProductReview>()
                .HasKey(e => e.ProductReviewId);

            modelBuilder.Entity<ProductSubcategory>()
                .HasKey(e => e.ProductSubcategoryId);

            modelBuilder.Entity<ProductSubcategory>()
                .HasMany(e => e.Products)
                .WithOne(e => e.ProductSubcategory)
                .HasForeignKey(e => e.ProductSubcategoryId);

            modelBuilder.Entity<ScrapReason>()
                .HasKey(e => e.ScrapReasonId);

            modelBuilder.Entity<ScrapReason>()
                .HasMany(e => e.WorkOrders)
                .WithOne(e => e.ScrapReason)
                .HasForeignKey(e => e.ScrapReasonId);

            modelBuilder.Entity<TransactionHistory>()
                .HasKey(e => e.TransactionId);

            modelBuilder.Entity<TransactionHistory>()
                .Property(e => e.TransactionType)
                .IsFixedLength();

            modelBuilder.Entity<TransactionHistoryArchive>()
                .HasKey(e => e.TransactionId);

            modelBuilder.Entity<TransactionHistoryArchive>()
                .Property(e => e.TransactionType)
                .IsFixedLength();

            modelBuilder.Entity<UnitMeasure>()
                .HasKey(e => e.UnitMeasureCode);

            modelBuilder.Entity<UnitMeasure>()
                .HasMany(e => e.BillOfMaterials)
                .WithOne(e => e.UnitMeasure)
                .HasForeignKey(e => e.UnitMeasureCode);

            modelBuilder.Entity<UnitMeasure>()
                .HasMany(e => e.SizeProducts)
                .WithOne(e => e.SizeUnitMeasure)
                .HasForeignKey(e => e.SizeUnitMeasureCode);

            modelBuilder.Entity<UnitMeasure>()
                .HasMany(e => e.WeightProducts)
                .WithOne(e => e.WeightUnitMeasure)
                .HasForeignKey(e => e.WeightUnitMeasureCode);

            modelBuilder.Entity<UnitMeasure>()
                .HasMany(e => e.ProductVendors)
                .WithOne(e => e.UnitMeasure)
                .HasForeignKey(e => e.UnitMeasureCode);

            modelBuilder.Entity<UnitMeasure>()
                .Property(e => e.UnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<WorkOrder>()
                .HasKey(e => e.WorkOrderId);

            modelBuilder.Entity<WorkOrder>()
                .HasMany(e => e.WorkOrderRoutings)
                .WithOne(e => e.WorkOrder)
                .HasForeignKey(e => e.WorkOrderId);


            modelBuilder.Entity<WorkOrderRouting>()
                .HasKey(e => new { 
                    e.WorkOrderId, 
                    e.ProductId, 
                    e.OperationSequence});


            modelBuilder.Entity<ProductVendor>()
                .HasKey(e => new { 
                    e.ProductId, 
                    e.BusinessEntityId});

            modelBuilder.Entity<ProductVendor>()
                .Property(e => e.UnitMeasureCode)
                .IsFixedLength();


            modelBuilder.Entity<PurchaseOrderDetail>()
                .HasKey(e => new { 
                    e.PurchaseOrderId, 
                    e.PurchaseOrderDetailId});

            modelBuilder.Entity<PurchaseOrderHeader>()
                .HasKey(e => e.PurchaseOrderId);

            modelBuilder.Entity<PurchaseOrderHeader>()
                .HasMany(e => e.PurchaseOrderDetails)
                .WithOne(e => e.PurchaseOrderHeader)
                .HasForeignKey(e => e.PurchaseOrderId);

            modelBuilder.Entity<ShipMethod>()
                .HasKey(e => e.ShipMethodId);

            modelBuilder.Entity<ShipMethod>()
                .HasMany(e => e.PurchaseOrderHeaders)
                .WithOne(e => e.ShipMethod)
                .HasForeignKey(e => e.ShipMethodId);

            modelBuilder.Entity<ShipMethod>()
                .HasMany(e => e.SalesOrderHeaders)
                .WithOne(e => e.ShipMethod)
                .HasForeignKey(e => e.ShipMethodId);

            modelBuilder.Entity<Vendor>()
                .HasKey(e => e.BusinessEntityId);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.ProductVendors)
                .WithOne(e => e.Vendor)
                .HasForeignKey(e => e.BusinessEntityId);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.PurchaseOrderHeaders)
                .WithOne(e => e.Vendor)
                .HasForeignKey(e => e.VendorId);


            modelBuilder.Entity<CountryRegionCurrency>()
                .HasKey(e => new { 
                    e.CountryRegionCode, 
                    e.CurrencyCode});

            modelBuilder.Entity<CountryRegionCurrency>()
                .Property(e => e.CurrencyCode)
                .IsFixedLength();

            modelBuilder.Entity<CreditCard>()
                .HasKey(e => e.CreditCardId);

            modelBuilder.Entity<CreditCard>()
                .HasMany(e => e.PersonCreditCards)
                .WithOne(e => e.CreditCard)
                .HasForeignKey(e => e.CreditCardId);

            modelBuilder.Entity<CreditCard>()
                .HasMany(e => e.SalesOrderHeaders)
                .WithOne(e => e.CreditCard)
                .HasForeignKey(e => e.CreditCardId);

            modelBuilder.Entity<Currency>()
                .HasKey(e => e.CurrencyCode);

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.CountryRegionCurrencies)
                .WithOne(e => e.Currency)
                .HasForeignKey(e => e.CurrencyCode);

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.FromCurrencyRates)
                .WithOne(e => e.FromCurrency)
                .HasForeignKey(e => e.FromCurrencyCode);

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.ToCurrencyRates)
                .WithOne(e => e.ToCurrency)
                .HasForeignKey(e => e.ToCurrencyCode);

            modelBuilder.Entity<Currency>()
                .Property(e => e.CurrencyCode)
                .IsFixedLength();

            modelBuilder.Entity<CurrencyRate>()
                .HasKey(e => e.CurrencyRateId);

            modelBuilder.Entity<CurrencyRate>()
                .HasMany(e => e.SalesOrderHeaders)
                .WithOne(e => e.CurrencyRate)
                .HasForeignKey(e => e.CurrencyRateId);

            modelBuilder.Entity<CurrencyRate>()
                .Property(e => e.FromCurrencyCode)
                .IsFixedLength();

            modelBuilder.Entity<CurrencyRate>()
                .Property(e => e.ToCurrencyCode)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .HasKey(e => e.CustomerId);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.SalesOrderHeaders)
                .WithOne(e => e.Customer)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<OrderTracking>()
                .HasKey(e => e.OrderTrackingId);


            modelBuilder.Entity<PersonCreditCard>()
                .HasKey(e => new { 
                    e.BusinessEntityId, 
                    e.CreditCardId});

            modelBuilder.Entity<SalesOrderJson>()
                .HasKey(e => e.SalesOrderId);


            modelBuilder.Entity<SalesOrderDetail>()
                .HasKey(e => new { 
                    e.SalesOrderId, 
                    e.SalesOrderDetailId});


            modelBuilder.Entity<SalesOrderDetailInmem>()
                .HasKey(e => new { 
                    e.SalesOrderId, 
                    e.SalesOrderDetailId});


            modelBuilder.Entity<SalesOrderDetailOndisk>()
                .HasKey(e => new { 
                    e.SalesOrderId, 
                    e.SalesOrderDetailId});

            modelBuilder.Entity<SalesOrderHeader>()
                .HasKey(e => e.SalesOrderId);

            modelBuilder.Entity<SalesOrderHeader>()
                .HasMany(e => e.SalesOrderDetails)
                .WithOne(e => e.SalesOrderHeader)
                .HasForeignKey(e => e.SalesOrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SalesOrderHeader>()
                .HasMany(e => e.SalesOrderHeaderSalesReasons)
                .WithOne(e => e.SalesOrderHeader)
                .HasForeignKey(e => e.SalesOrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SalesOrderHeaderInmem>()
                .HasKey(e => e.SalesOrderId);

            modelBuilder.Entity<SalesOrderHeaderInmem>()
                .HasMany(e => e.SalesOrderDetailInmems)
                .WithOne(e => e.SalesOrderHeaderInmem)
                .HasForeignKey(e => e.SalesOrderId);

            modelBuilder.Entity<SalesOrderHeaderOndisk>()
                .HasKey(e => e.SalesOrderId);

            modelBuilder.Entity<SalesOrderHeaderOndisk>()
                .HasMany(e => e.SalesOrderDetailOndisks)
                .WithOne(e => e.SalesOrderHeaderOndisk)
                .HasForeignKey(e => e.SalesOrderId);


            modelBuilder.Entity<SalesOrderHeaderSalesReason>()
                .HasKey(e => new { 
                    e.SalesOrderId, 
                    e.SalesReasonId});

            modelBuilder.Entity<SalesPerson>()
                .HasKey(e => e.BusinessEntityId);

            modelBuilder.Entity<SalesPerson>()
                .HasMany(e => e.SalesOrderHeaders)
                .WithOne(e => e.SalesPerson)
                .HasForeignKey(e => e.SalesPersonId);

            modelBuilder.Entity<SalesPerson>()
                .HasMany(e => e.SalesPersonQuotaHistories)
                .WithOne(e => e.SalesPerson)
                .HasForeignKey(e => e.BusinessEntityId);

            modelBuilder.Entity<SalesPerson>()
                .HasMany(e => e.SalesTerritoryHistories)
                .WithOne(e => e.SalesPerson)
                .HasForeignKey(e => e.BusinessEntityId);

            modelBuilder.Entity<SalesPerson>()
                .HasMany(e => e.Stores)
                .WithOne(e => e.SalesPerson)
                .HasForeignKey(e => e.SalesPersonId);


            modelBuilder.Entity<SalesPersonQuotaHistory>()
                .HasKey(e => new { 
                    e.BusinessEntityId, 
                    e.QuotaDate});

            modelBuilder.Entity<SalesReason>()
                .HasKey(e => e.SalesReasonId);

            modelBuilder.Entity<SalesReason>()
                .HasMany(e => e.SalesOrderHeaderSalesReasons)
                .WithOne(e => e.SalesReason)
                .HasForeignKey(e => e.SalesReasonId);

            modelBuilder.Entity<SalesTaxRate>()
                .HasKey(e => e.SalesTaxRateId);

            modelBuilder.Entity<SalesTerritory>()
                .HasKey(e => e.TerritoryId);

            modelBuilder.Entity<SalesTerritory>()
                .HasMany(e => e.Customers)
                .WithOne(e => e.SalesTerritory)
                .HasForeignKey(e => e.TerritoryId);

            modelBuilder.Entity<SalesTerritory>()
                .HasMany(e => e.SalesOrderHeaders)
                .WithOne(e => e.SalesTerritory)
                .HasForeignKey(e => e.TerritoryId);

            modelBuilder.Entity<SalesTerritory>()
                .HasMany(e => e.SalesPersons)
                .WithOne(e => e.SalesTerritory)
                .HasForeignKey(e => e.TerritoryId);

            modelBuilder.Entity<SalesTerritory>()
                .HasMany(e => e.SalesTerritoryHistories)
                .WithOne(e => e.SalesTerritory)
                .HasForeignKey(e => e.TerritoryId);

            modelBuilder.Entity<SalesTerritory>()
                .HasMany(e => e.StateProvinces)
                .WithOne(e => e.SalesTerritory)
                .HasForeignKey(e => e.TerritoryId);


            modelBuilder.Entity<SalesTerritoryHistory>()
                .HasKey(e => new { 
                    e.BusinessEntityId, 
                    e.StartDate, 
                    e.TerritoryId});

            modelBuilder.Entity<ShoppingCartItem>()
                .HasKey(e => e.ShoppingCartItemId);

            modelBuilder.Entity<SpecialOffer>()
                .HasKey(e => e.SpecialOfferId);

            modelBuilder.Entity<SpecialOffer>()
                .HasMany(e => e.SpecialOfferProducts)
                .WithOne(e => e.SpecialOffer)
                .HasForeignKey(e => e.SpecialOfferId);

            modelBuilder.Entity<SpecialOfferInmem>()
                .HasKey(e => e.SpecialOfferId);

            modelBuilder.Entity<SpecialOfferInmem>()
                .HasMany(e => e.SpecialOfferProductInmems)
                .WithOne(e => e.SpecialOfferInmem)
                .HasForeignKey(e => e.SpecialOfferId);

            modelBuilder.Entity<SpecialOfferOndisk>()
                .HasKey(e => e.SpecialOfferId);

            modelBuilder.Entity<SpecialOfferOndisk>()
                .HasMany(e => e.SpecialOfferProductOndisks)
                .WithOne(e => e.SpecialOfferOndisk)
                .HasForeignKey(e => e.SpecialOfferId);


            modelBuilder.Entity<SpecialOfferProduct>()
                .HasKey(e => new { 
                    e.SpecialOfferId, 
                    e.ProductId});

            modelBuilder.Entity<SpecialOfferProduct>()
                .HasMany(e => e.SalesOrderDetails)
                .WithOne(e => e.SpecialOfferProduct)
                .HasForeignKey(e => new { 
                    e.SpecialOfferId
,                    e.ProductId
                
                 });


            modelBuilder.Entity<SpecialOfferProductInmem>()
                .HasKey(e => new { 
                    e.SpecialOfferId, 
                    e.ProductId});

            modelBuilder.Entity<SpecialOfferProductInmem>()
                .HasMany(e => e.SalesOrderDetailInmems)
                .WithOne(e => e.SpecialOfferProductInmem)
                .HasForeignKey(e => new { 
                    e.SpecialOfferId
,                    e.ProductId
                
                 });


            modelBuilder.Entity<SpecialOfferProductOndisk>()
                .HasKey(e => new { 
                    e.SpecialOfferId, 
                    e.ProductId});

            modelBuilder.Entity<SpecialOfferProductOndisk>()
                .HasMany(e => e.SalesOrderDetailOndisks)
                .WithOne(e => e.SpecialOfferProductOndisk)
                .HasForeignKey(e => new { 
                    e.SpecialOfferId
,                    e.ProductId
                
                 });

            modelBuilder.Entity<Store>()
                .HasKey(e => e.BusinessEntityId);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Customers)
                .WithOne(e => e.Store)
                .HasForeignKey(e => e.StoreId);

            modelBuilder.Entity<TrackingEvent>()
                .HasKey(e => e.TrackingEventId);

        }
    }
}
