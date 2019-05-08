using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models6
{
    public class SampleDbContext : DbContext{
        public SampleDbContext()
            : base("name=sampledb")
        {
            Database.SetInitializer<SampleDbContext>(null);
            //Database.Log = x => Console.Out.WriteLine(x);
        }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<History> History { get; set; }
        public virtual DbSet<SampleTable1> SampleTable1 { get; set; }
        public virtual DbSet<SrcFile> SrcFile { get; set; }
        public virtual DbSet<SysUser> SysUser { get; set; }
        public virtual DbSet<Table1> Table1 { get; set; }
        public virtual DbSet<Table2> Table2 { get; set; }
        public virtual DbSet<Table3> Table3 { get; set; }
        public virtual DbSet<Table4> Table4 { get; set; }
        public virtual DbSet<Table5> Table5 { get; set; }
        public virtual DbSet<Table5b> Table5b { get; set; }
        public virtual DbSet<Table6> Table6 { get; set; }
        public virtual DbSet<Table7> Table7 { get; set; }
        public virtual DbSet<Table8> Table8 { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<VssHistory> VssHistory { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<History>()
                .Property(e => e.Date)
                .IsUnicode(false);

            modelBuilder.Entity<History>()
                .Property(e => e.Date)
                .IsFixedLength();

            modelBuilder.Entity<History>()
                .Property(e => e.Time)
                .IsUnicode(false);

            modelBuilder.Entity<History>()
                .Property(e => e.Time)
                .IsFixedLength();

            modelBuilder.Entity<History>()
                .Property(e => e.File)
                .IsUnicode(false);

            modelBuilder.Entity<History>()
                .Property(e => e.User)
                .IsUnicode(false);

            modelBuilder.Entity<SysUser>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<SysUser>()
                .Property(e => e.MailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<SysUser>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<SysUser>()
                .Property(e => e.Otp)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .HasMany(e => e.Table2s)
                .WithOptional(e => e.Table1)
                .HasForeignKey(e => e.Table1Id);

            modelBuilder.Entity<Table1>()
                .HasMany(e => e.Table3s)
                .WithRequired(e => e.Table1)
                .HasForeignKey(e => e.Table1Id);

            modelBuilder.Entity<Table1>()
                .HasMany(e => e.Table4s)
                .WithRequired(e => e.Table1)
                .HasForeignKey(e => e.Table1Id);

            modelBuilder.Entity<Table5>()
                .HasMany(e => e.Table6s)
                .WithOptional(e => e.Table5)
                .HasForeignKey(e => new { 
                    e.Table5Key1
,                    e.Table5Key2
                
                 })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Table5>()
                .HasMany(e => e.Table7s)
                .WithOptional(e => e.Table5)
                .HasForeignKey(e => new { 
                    e.Table5bKey1
,                    e.Table5bKey2
                
                 })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Table5b>()
                .HasMany(e => e.Table7s)
                .WithOptional(e => e.Table5b)
                .HasForeignKey(e => e.Table5bKey1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Table5b>()
                .HasMany(e => e.Table7s1)
                .WithOptional(e => e.Table5b1)
                .HasForeignKey(e => e.Table5bKey1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Table8>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Table8>()
                .Property(e => e.Code)
                .IsFixedLength();

            modelBuilder.Entity<VssHistory>()
                .Property(e => e.Date)
                .IsUnicode(false);

            modelBuilder.Entity<VssHistory>()
                .Property(e => e.Date)
                .IsFixedLength();

            modelBuilder.Entity<VssHistory>()
                .Property(e => e.Time)
                .IsUnicode(false);

            modelBuilder.Entity<VssHistory>()
                .Property(e => e.Time)
                .IsFixedLength();

            modelBuilder.Entity<VssHistory>()
                .Property(e => e.File)
                .IsUnicode(false);

            modelBuilder.Entity<VssHistory>()
                .Property(e => e.User)
                .IsUnicode(false);

        }
    }
}
