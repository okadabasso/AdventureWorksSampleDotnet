using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sakila.Models
{
    [Table("store")]
    public partial class Store
    {
        public Store()
        {
            Customers = new HashSet<Customer>();
            Inventories = new HashSet<Inventory>();
            Staffs = new HashSet<Staff>();

        }

        ///<summary></summary>
        [Key]
        [Column("store_id", Order = 0, TypeName = "tinyint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public sbyte StoreId { get; set; }

        ///<summary></summary>
        [Column("manager_staff_id")]
        public sbyte ManagerStaffId { get; set; }

        ///<summary></summary>
        [Column("address_id")]
        public short AddressId { get; set; }

        ///<summary></summary>
        [Column("last_update", Order = 3, TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory> Inventories { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff> Staffs { get; set; }

        public virtual Address Address { get; set; }

        public virtual Staff ManagerStaff { get; set; }

    }
}
