using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SakilaCore.Models
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
        ///<remarks>YES</remarks>
        [Key]
        [Column("store_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte StoreId { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Column("manager_staff_id")]
        public byte ManagerStaffId { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Column("address_id")]
        public ushort AddressId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("last_update", Order = 3)]
        public DateTime LastUpdate { get; set; }


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
