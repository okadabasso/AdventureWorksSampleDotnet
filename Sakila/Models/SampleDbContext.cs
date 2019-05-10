using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using MySql.Data.EntityFramework;
namespace Sakila.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class SampleDbContext : DbContext{
        public SampleDbContext()
            : base("name=sampledb")
        {
            Database.SetInitializer<SampleDbContext>(null);
            //Database.Log = x => Console.Out.WriteLine(x);
        }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Film> Film { get; set; }
        public DbSet<FilmActor> FilmActor { get; set; }
        public DbSet<FilmCategory> FilmCategory { get; set; }
        public DbSet<FilmText> FilmText { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Rental> Rental { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Store> Store { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Actor>()
                .HasMany(e => e.FilmActors)
                .WithRequired(e => e.Actor)
                .HasForeignKey(e => e.ActorId);

            modelBuilder.Entity<Actor>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Actor>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Customers)
                .WithRequired(e => e.Address)
                .HasForeignKey(e => e.AddressId);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Staffs)
                .WithRequired(e => e.Address)
                .HasForeignKey(e => e.AddressId);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Stores)
                .WithRequired(e => e.Address)
                .HasForeignKey(e => e.AddressId);

            modelBuilder.Entity<Address>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.District)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.FilmCategories)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.CategoryId);

            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Addresses)
                .WithRequired(e => e.City)
                .HasForeignKey(e => e.CityId);

            modelBuilder.Entity<City>()
                .Property(e => e.City1)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Cities)
                .WithRequired(e => e.Country)
                .HasForeignKey(e => e.CountryId);

            modelBuilder.Entity<Country>()
                .Property(e => e.Country1)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Rentals)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<Customer>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .HasMany(e => e.FilmActors)
                .WithRequired(e => e.Film)
                .HasForeignKey(e => e.FilmId);

            modelBuilder.Entity<Film>()
                .HasMany(e => e.FilmCategories)
                .WithRequired(e => e.Film)
                .HasForeignKey(e => e.FilmId);

            modelBuilder.Entity<Film>()
                .HasMany(e => e.Inventories)
                .WithRequired(e => e.Film)
                .HasForeignKey(e => e.FilmId);

            modelBuilder.Entity<Film>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.RentalRate)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Film>()
                .Property(e => e.ReplacementCost)
                .HasPrecision(5, 2);

            modelBuilder.Entity<FilmText>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<FilmText>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Inventory>()
                .HasMany(e => e.Rentals)
                .WithRequired(e => e.Inventory)
                .HasForeignKey(e => e.InventoryId);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.Films)
                .WithRequired(e => e.Language)
                .HasForeignKey(e => e.LanguageId);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.Films1)
                .WithOptional(e => e.Language1)
                .HasForeignKey(e => e.OriginalLanguageId);

            modelBuilder.Entity<Language>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Payment>()
                .Property(e => e.Amount)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Rental>()
                .HasMany(e => e.Payments)
                .WithOptional(e => e.Rental)
                .HasForeignKey(e => e.RentalId);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Staff)
                .HasForeignKey(e => e.StaffId);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Rentals)
                .WithRequired(e => e.Staff)
                .HasForeignKey(e => e.StaffId);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Stores)
                .WithRequired(e => e.Staff)
                .HasForeignKey(e => e.ManagerStaffId);

            modelBuilder.Entity<Staff>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Customers)
                .WithRequired(e => e.Store)
                .HasForeignKey(e => e.StoreId);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Inventories)
                .WithRequired(e => e.Store)
                .HasForeignKey(e => e.StoreId);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Staffs)
                .WithRequired(e => e.Store)
                .HasForeignKey(e => e.StoreId);

        }
    }
}
