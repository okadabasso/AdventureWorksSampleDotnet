using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sakila.Models
{
    [Table("customer")]
    public partial class Customer
    {
        public Customer()
        {
            Payments = new HashSet<Payment>();
            Rentals = new HashSet<Rental>();

        }

        ///<summary></summary>
        [Key]
        [Column("customer_id", Order = 0, TypeName = "smallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short CustomerId { get; set; }

        ///<summary></summary>
        [Column("store_id")]
        public sbyte StoreId { get; set; }

        ///<summary></summary>
        [Required]
        [Column("first_name", Order = 2, TypeName = "varchar")]
        [StringLength(45)]
        public string FirstName { get; set; }

        ///<summary></summary>
        [Required]
        [Column("last_name", Order = 3, TypeName = "varchar")]
        [StringLength(45)]
        public string LastName { get; set; }

        ///<summary></summary>
        [Column("email", Order = 4, TypeName = "varchar")]
        [StringLength(50)]
        public string Email { get; set; }

        ///<summary></summary>
        [Column("address_id")]
        public short AddressId { get; set; }

        ///<summary></summary>
        [Column("active", Order = 6, TypeName = "tinyint")]
        public sbyte Active { get; set; }

        ///<summary></summary>
        [Column("create_date", Order = 7, TypeName = "datetime")]
        public DateTime CreateDate { get; set; }

        ///<summary></summary>
        [Column("last_update", Order = 8, TypeName = "timestamp")]
        public DateTime? LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rental> Rentals { get; set; }

        public virtual Address Address { get; set; }

        public virtual Store Store { get; set; }

    }
}
