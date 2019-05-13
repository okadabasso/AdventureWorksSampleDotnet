using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MySql.Data;
using Microsoft.EntityFrameworkCore;
namespace SakilaCore.Models
{
    public class SampleDbContext : DbContext{
        public SampleDbContext()
            : base()
        {
            //Database.Log = x => Console.Out.WriteLine(x);
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<FilmActor> FilmActors { get; set; }
        public DbSet<FilmCategory> FilmCategories { get; set; }
        public DbSet<FilmText> FilmTexts { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Store> Stores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("server=localhost;database=sakila;uid=sakilauser;pwd=sakilauser");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Actor>()
                .HasKey(e => e.ActorId);
            modelBuilder.Entity<Actor>()
                .HasMany(e => e.FilmActors)
                .WithOne(e => e.Actor)
                .HasForeignKey(e => e.ActorId);

            modelBuilder.Entity<Address>()
                .HasKey(e => e.AddressId);
            modelBuilder.Entity<Address>()
                .HasMany(e => e.Customers)
                .WithOne(e => e.Address)
                .HasForeignKey(e => e.AddressId);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Staffs)
                .WithOne(e => e.Address)
                .HasForeignKey(e => e.AddressId);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Stores)
                .WithOne(e => e.Address)
                .HasForeignKey(e => e.AddressId);

            modelBuilder.Entity<Category>()
                .HasKey(e => e.CategoryId);
            modelBuilder.Entity<Category>()
                .HasMany(e => e.FilmCategories)
                .WithOne(e => e.Category)
                .HasForeignKey(e => e.CategoryId);

            modelBuilder.Entity<City>()
                .HasKey(e => e.CityId);
            modelBuilder.Entity<City>()
                .HasMany(e => e.Addresses)
                .WithOne(e => e.City)
                .HasForeignKey(e => e.CityId);

            modelBuilder.Entity<Country>()
                .HasKey(e => e.CountryId);
            modelBuilder.Entity<Country>()
                .HasMany(e => e.Cities)
                .WithOne(e => e.Country)
                .HasForeignKey(e => e.CountryId);

            modelBuilder.Entity<Customer>()
                .HasKey(e => e.CustomerId);
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Payments)
                .WithOne(e => e.Customer)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Rentals)
                .WithOne(e => e.Customer)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<Film>()
                .HasKey(e => e.FilmId);
            modelBuilder.Entity<Film>()
                .HasMany(e => e.FilmActors)
                .WithOne(e => e.Film)
                .HasForeignKey(e => e.FilmId);

            modelBuilder.Entity<Film>()
                .HasMany(e => e.FilmCategories)
                .WithOne(e => e.Film)
                .HasForeignKey(e => e.FilmId);

            modelBuilder.Entity<Film>()
                .HasMany(e => e.Inventories)
                .WithOne(e => e.Film)
                .HasForeignKey(e => e.FilmId);

            modelBuilder.Entity<FilmActor>()

                .HasKey(e => new { 
                    e.ActorId
,                    e.FilmId
                
                 });
            modelBuilder.Entity<FilmCategory>()

                .HasKey(e => new { 
                    e.FilmId
,                    e.CategoryId
                
                 });
            modelBuilder.Entity<FilmText>()
                .HasKey(e => e.FilmId);
            modelBuilder.Entity<Inventory>()
                .HasKey(e => e.InventoryId);
            modelBuilder.Entity<Inventory>()
                .HasMany(e => e.Rentals)
                .WithOne(e => e.Inventory)
                .HasForeignKey(e => e.InventoryId);

            modelBuilder.Entity<Language>()
                .HasKey(e => e.LanguageId);
            modelBuilder.Entity<Language>()
                .HasMany(e => e.Films)
                .WithOne(e => e.Language)
                .HasForeignKey(e => e.LanguageId);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.Films1)
                .WithOne(e => e.Language1)
                .HasForeignKey(e => e.OriginalLanguageId);

            modelBuilder.Entity<Language>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Payment>()
                .HasKey(e => e.PaymentId);
            modelBuilder.Entity<Rental>()
                .HasKey(e => e.RentalId);
            modelBuilder.Entity<Rental>()
                .HasMany(e => e.Payments)
                .WithOne(e => e.Rental)
                .HasForeignKey(e => e.RentalId);

            modelBuilder.Entity<Staff>()
                .HasKey(e => e.StaffId);
            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Payments)
                .WithOne(e => e.Staff)
                .HasForeignKey(e => e.StaffId);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Rentals)
                .WithOne(e => e.Staff)
                .HasForeignKey(e => e.StaffId);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Stores)
                .WithOne(e => e.Staff)
                .HasForeignKey(e => e.ManagerStaffId);

            modelBuilder.Entity<Store>()
                .HasKey(e => e.StoreId);
            modelBuilder.Entity<Store>()
                .HasMany(e => e.Customers)
                .WithOne(e => e.Store)
                .HasForeignKey(e => e.StoreId);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Inventories)
                .WithOne(e => e.Store)
                .HasForeignKey(e => e.StoreId);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Staffs)
                .WithOne(e => e.Store)
                .HasForeignKey(e => e.StoreId);

        }
    }
}
