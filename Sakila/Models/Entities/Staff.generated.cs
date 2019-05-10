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
            StaffId = 0;
            FirstName = null;
            LastName = null;
            AddressId = 0;
            Picture = null;
            Email = null;
            StoreId = 0;
            Active = 0;
            Username = null;
            Password = null;
            LastUpdate = null;
            Payments = new HashSet<Payment>();
            Rentals = new HashSet<Rental>();
            Stores = new HashSet<Store>();

        }

        ///<summary>column:staff_id</summary>
        [Key]
        [Column("staff_id", Order = 0, TypeName = "tinyint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte StaffId { get; set; }

        ///<summary>column:first_name</summary>
        [Required]
        [Column("first_name", Order = 1, TypeName = "varchar")]
        public string FirstName { get; set; }

        ///<summary>column:last_name</summary>
        [Required]
        [Column("last_name", Order = 2, TypeName = "varchar")]
        public string LastName { get; set; }

        ///<summary>column:address_id</summary>
        [Column("address_id")]
        public short AddressId { get; set; }

        ///<summary>column:picture</summary>
        [Column("picture", Order = 4, TypeName = "blob")]
        public object Picture { get; set; }

        ///<summary>column:email</summary>
        [Column("email", Order = 5, TypeName = "varchar")]
        public string Email { get; set; }

        ///<summary>column:store_id</summary>
        [Column("store_id")]
        public byte StoreId { get; set; }

        ///<summary>column:active</summary>
        [Column("active", Order = 7, TypeName = "tinyint")]
        public byte Active { get; set; }

        ///<summary>column:username</summary>
        [Required]
        [Column("username", Order = 8, TypeName = "varchar")]
        public string Username { get; set; }

        ///<summary>column:password</summary>
        [Column("password", Order = 9, TypeName = "varchar")]
        public string Password { get; set; }

        ///<summary>column:last_update</summary>
        [Required]
        [Column("last_update", Order = 10, TypeName = "timestamp")]
        public byte[] LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rental> Rentals { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store> Stores { get; set; }

        public virtual Address Address { get; set; }

        public virtual Store Store { get; set; }

    }
}
