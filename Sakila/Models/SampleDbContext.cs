using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using MySql.Data.EntityFramework;
namespace Sakila.Models
{
    public class SampleDbContext : DbContext{
        public SampleDbContext()
            : base("name=sampledb")
        {
            Database.SetInitializer<SampleDbContext>(null);
            //Database.Log = x => Console.Out.WriteLine(x);
        }
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<FilmActor> FilmActors { get; set; }
        public virtual DbSet<FilmCategory> FilmCategories { get; set; }
        public virtual DbSet<FilmText> FilmTexts { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Rental> Rentals { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Actor>()
                .HasMany(e => e.FilmActors)
                .WithRequired(e => e.Actor)
                .HasForeignKey(e => e.ActorId);

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

            modelBuilder.Entity<Category>()
                .HasMany(e => e.FilmCategories)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.CategoryId);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Addresses)
                .WithRequired(e => e.City)
                .HasForeignKey(e => e.CityId);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Cities)
                .WithRequired(e => e.Country)
                .HasForeignKey(e => e.CountryId);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Rentals)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.CustomerId);

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
                .Property(e => e.RentalRate)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Film>()
                .Property(e => e.ReplacementCost)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Inventory>()
                .HasMany(e => e.Rentals)
                .WithRequired(e => e.Inventory)
                .HasForeignKey(e => e.InventoryId);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.Films)
                .WithRequired(e => e.Language)
                .HasForeignKey(e => e.LanguageId);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.OriginalFilms)
                .WithOptional(e => e.OriginalLanguage)
                .HasForeignKey(e => e.OriginalLanguageId);

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
                .HasMany(e => e.ManagerStore)
                .WithRequired(e => e.ManagerStaff)
                .HasForeignKey(e => e.ManagerStaffId);

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
