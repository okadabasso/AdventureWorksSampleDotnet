using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SakilaCore.Models
{
    [Table("staff", Schema="sakila")]
    public partial class Staff
    {
        public Staff()
        {
            Payments = new HashSet<Payment>();
            Rentals = new HashSet<Rental>();
            ManagerStore = new HashSet<Store>();

        }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Key]
        [Column("staff_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte StaffId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Required]
        [Column("first_name", Order = 1)]
        [StringLength(45)]
        public string FirstName { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Required]
        [Column("last_name", Order = 2)]
        [StringLength(45)]
        public string LastName { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Column("address_id")]
        public ushort AddressId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("picture", Order = 4)]
        public byte[] Picture { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("email", Order = 5)]
        [StringLength(50)]
        public string Email { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Column("store_id")]
        public byte StoreId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("active", Order = 7)]
        public bool Active { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Required]
        [Column("username", Order = 8)]
        [StringLength(16)]
        public string Username { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("password", Order = 9)]
        [StringLength(40)]
        public string Password { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("last_update", Order = 10)]
        public DateTime LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rental> Rentals { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store> ManagerStore { get; set; }

        public virtual Address Address { get; set; }

        public virtual Store Store { get; set; }

    }
}
