using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Sakila.Models
{
    [Table("customer")]
    public partial class Customer
    {
        public Customer()
        {
            CustomerId = 0;
            StoreId = 0;
            FirstName = null;
            LastName = null;
            Email = null;
            AddressId = 0;
            Active = 0;
            CreateDate = DateTime.Parse("0001/01/01 0:00:00");
            LastUpdate = null;
            Payments = new HashSet<Payment>();
            Rentals = new HashSet<Rental>();

        }

        ///<summary>column:customer_id</summary>
        [Key]
        [Column("customer_id", Order = 0, TypeName = "smallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short CustomerId { get; set; }

        ///<summary>column:store_id</summary>
        [Column("store_id")]
        public byte StoreId { get; set; }

        ///<summary>column:first_name</summary>
        [Required]
        [Column("first_name", Order = 2, TypeName = "varchar")]
        public string FirstName { get; set; }

        ///<summary>column:last_name</summary>
        [Required]
        [Column("last_name", Order = 3, TypeName = "varchar")]
        public string LastName { get; set; }

        ///<summary>column:email</summary>
        [Column("email", Order = 4, TypeName = "varchar")]
        public string Email { get; set; }

        ///<summary>column:address_id</summary>
        [Column("address_id")]
        public short AddressId { get; set; }

        ///<summary>column:active</summary>
        [Column("active", Order = 6, TypeName = "tinyint")]
        public byte Active { get; set; }

        ///<summary>column:create_date</summary>
        [Column("create_date", Order = 7, TypeName = "datetime")]
        public DateTime CreateDate { get; set; }

        ///<summary>column:last_update</summary>
        [Column("last_update", Order = 8, TypeName = "timestamp")]
        public byte[] LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rental> Rentals { get; set; }

        public virtual Address Address { get; set; }

        public virtual Store Store { get; set; }

    }
}
