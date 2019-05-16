using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SakilaCore.Models
{
    [Table("customer", Schema="sakila")]
    public partial class Customer
    {
        public Customer()
        {
            Payments = new HashSet<Payment>();
            Rentals = new HashSet<Rental>();

        }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Key]
        [Column("customer_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ushort CustomerId { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Column("store_id")]
        public byte StoreId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Required]
        [Column("first_name", Order = 2)]
        [StringLength(45)]
        public string FirstName { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Required]
        [Column("last_name", Order = 3)]
        [StringLength(45)]
        public string LastName { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("email", Order = 4)]
        [StringLength(50)]
        public string Email { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Column("address_id")]
        public ushort AddressId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("active", Order = 6)]
        public bool Active { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("create_date", Order = 7)]
        public DateTime CreateDate { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("last_update", Order = 8)]
        public DateTime? LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rental> Rentals { get; set; }

        public virtual Address Address { get; set; }

        public virtual Store Store { get; set; }

    }
}
