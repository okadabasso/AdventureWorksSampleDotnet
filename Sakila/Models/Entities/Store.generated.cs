using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Sakila.Models
{
    [Table("store")]
    public partial class Store
    {
        public Store()
        {
            StoreId = 0;
            ManagerStaffId = 0;
            AddressId = 0;
            LastUpdate = null;
            Customers = new HashSet<Customer>();
            Inventories = new HashSet<Inventory>();
            Staffs = new HashSet<Staff>();

        }

        ///<summary>column:store_id</summary>
        [Key]
        [Column("store_id", Order = 0, TypeName = "tinyint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte StoreId { get; set; }

        ///<summary>column:manager_staff_id</summary>
        [Column("manager_staff_id")]
        public byte ManagerStaffId { get; set; }

        ///<summary>column:address_id</summary>
        [Column("address_id")]
        public short AddressId { get; set; }

        ///<summary>column:last_update</summary>
        [Required]
        [Column("last_update", Order = 3, TypeName = "timestamp")]
        public byte[] LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory> Inventories { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff> Staffs { get; set; }

        public virtual Address Address { get; set; }

        public virtual Staff Staff { get; set; }

    }
}
