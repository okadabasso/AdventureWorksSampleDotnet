using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SakilaCore.Models
{
    [Table("address")]
    public partial class Address
    {
        public Address()
        {
            Customers = new HashSet<Customer>();
            Staffs = new HashSet<Staff>();
            Stores = new HashSet<Store>();

        }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Key]
        [Column("address_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ushort AddressId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Required]
        [Column("address", Order = 1)]
        [StringLength(50)]
        public string Address1 { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("address2", Order = 2)]
        [StringLength(50)]
        public string Address2 { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Required]
        [Column("district", Order = 3)]
        [StringLength(20)]
        public string District { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Column("city_id")]
        public ushort CityId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("postal_code", Order = 5)]
        [StringLength(10)]
        public string PostalCode { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Required]
        [Column("phone", Order = 6)]
        [StringLength(20)]
        public string Phone { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("last_update", Order = 8)]
        public DateTime LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff> Staffs { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store> Stores { get; set; }

        public virtual City City { get; set; }

    }
}
