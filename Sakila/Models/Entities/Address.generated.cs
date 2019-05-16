using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sakila.Models
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
        [Key]
        [Column("address_id", Order = 0, TypeName = "smallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short AddressId { get; set; }

        ///<summary></summary>
        [Required]
        [Column("address", Order = 1, TypeName = "varchar")]
        [StringLength(50)]
        public string Address1 { get; set; }

        ///<summary></summary>
        [Column("address2", Order = 2, TypeName = "varchar")]
        [StringLength(50)]
        public string Address2 { get; set; }

        ///<summary></summary>
        [Required]
        [Column("district", Order = 3, TypeName = "varchar")]
        [StringLength(20)]
        public string District { get; set; }

        ///<summary></summary>
        [Column("city_id")]
        public short CityId { get; set; }

        ///<summary></summary>
        [Column("postal_code", Order = 5, TypeName = "varchar")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        ///<summary></summary>
        [Required]
        [Column("phone", Order = 6, TypeName = "varchar")]
        [StringLength(20)]
        public string Phone { get; set; }

        ///<summary></summary>
        [Required]
        [Column("location", Order = 7, TypeName = "geometry")]
        public object Location { get; set; }

        ///<summary></summary>
        [Column("last_update", Order = 8, TypeName = "timestamp")]
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
