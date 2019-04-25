namespace AdventureWorksSample1.Models4
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=SampleDbModel2")
        {
            Database.SetInitializer<Model1>(null);
        }

        public virtual DbSet<sample_table1> sample_table1 { get; set; }
        public virtual DbSet<SYS_USER> SYS_USER { get; set; }
        public virtual DbSet<table1> table1 { get; set; }
        public virtual DbSet<table2> table2 { get; set; }
        public virtual DbSet<table3> table3 { get; set; }
        public virtual DbSet<table4> table4 { get; set; }
        public virtual DbSet<table5> table5 { get; set; }
        public virtual DbSet<table5b> table5b { get; set; }
        public virtual DbSet<table6> table6 { get; set; }
        public virtual DbSet<table7> table7 { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<src_file> src_file { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<SYS_USER>()
            //    .Property(e => e.USER_ID)
            //    .IsUnicode(false);

            //modelBuilder.Entity<SYS_USER>()
            //    .Property(e => e.MAIL_ADDRESS)
            //    .IsUnicode(false);

            //modelBuilder.Entity<SYS_USER>()
            //    .Property(e => e.PASSWORD)
            //    .IsUnicode(false);

            //modelBuilder.Entity<SYS_USER>()
            //    .Property(e => e.OTP)
            //    .IsUnicode(false);

            //modelBuilder.Entity<SYS_USER>()
            //    .Property(e => e.VERSION)
            //    .IsFixedLength();

            //modelBuilder.Entity<table1>()
            //    .HasMany(e => e.table2)
            //    .WithOptional(e => e.table1)
            //    .HasForeignKey(e => e.table1_id)
            //    .WillCascadeOnDelete();

            //modelBuilder.Entity<table1>()
            //    .HasMany(e => e.table3)
            //    .WithRequired(e => e.table1)
            //    .HasForeignKey(e => e.table1_id);

            //modelBuilder.Entity<table1>()
            //    .HasMany(e => e.table4)
            //    .WithRequired(e => e.table1)
            //    .HasForeignKey(e => e.table1_id);

            //modelBuilder.Entity<table5>()
            //    .HasMany(e => e.table6)
            //    .WithOptional(e => e.table5)
            //    .HasForeignKey(e => new { e.table5_key1, e.tabke5_key2 })
            //    .WillCascadeOnDelete();

            modelBuilder.Entity<table5>()
                .HasMany(e => e.table7)
                .WithOptional(e => e.refTable)
                .HasForeignKey(e => new {e.table5_key1, e.table5_key2})
                ;
            modelBuilder.Entity<table5b>()
                .HasMany(e => e.table7)
                .WithOptional(e => e.refTable5b)
                .HasForeignKey(e => e.table5_key1)
                ;

        }
    }
}
