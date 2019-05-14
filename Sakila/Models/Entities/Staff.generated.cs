using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Sakila.Models
{
    [Table("staff")]
    public partial class Staff
    {
        public Staff()
        {
            Payments = new HashSet<Payment>();
            Rentals = new HashSet<Rental>();
            ManagerStore = new HashSet<Store>();

        }

        ///<summary></summary>
        [Key]
        [Column("staff_id", Order = 0, TypeName = "tinyint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public sbyte StaffId { get; set; }

        ///<summary></summary>
        [Required]
        [Column("first_name", Order = 1, TypeName = "varchar")]
        [StringLength(45)]
        public string FirstName { get; set; }

        ///<summary></summary>
        [Required]
        [Column("last_name", Order = 2, TypeName = "varchar")]
        [StringLength(45)]
        public string LastName { get; set; }

        ///<summary></summary>
        [Column("address_id")]
        public short AddressId { get; set; }

        ///<summary></summary>
        [Column("picture", Order = 4, TypeName = "blob")]
        public object Picture { get; set; }

        ///<summary></summary>
        [Column("email", Order = 5, TypeName = "varchar")]
        [StringLength(50)]
        public string Email { get; set; }

        ///<summary></summary>
        [Column("store_id")]
        public sbyte StoreId { get; set; }

        ///<summary></summary>
        [Column("active", Order = 7, TypeName = "tinyint")]
        public sbyte Active { get; set; }

        ///<summary></summary>
        [Required]
        [Column("username", Order = 8, TypeName = "varchar")]
        [StringLength(16)]
        public string Username { get; set; }

        ///<summary></summary>
        [Column("password", Order = 9, TypeName = "varchar")]
        [StringLength(40)]
        public string Password { get; set; }

        ///<summary></summary>
        [Column("last_update", Order = 10, TypeName = "timestamp")]
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
