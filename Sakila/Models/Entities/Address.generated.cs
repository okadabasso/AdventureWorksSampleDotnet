using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Sakila.Models
{
    [Table("address")]
    public partial class Address
    {
        public Address()
        {
            AddressId = 0;
            Address1 = null;
            Address2 = null;
            District = null;
            CityId = 0;
            PostalCode = null;
            Phone = null;
            Location = null;
            LastUpdate = null;
            Customers = new HashSet<Customer>();
            Staffs = new HashSet<Staff>();
            Stores = new HashSet<Store>();

        }

        ///<summary>column:address_id</summary>
        [Key]
        [Column("address_id", Order = 0, TypeName = "smallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short AddressId { get; set; }

        ///<summary>column:address</summary>
        [Required]
        [Column("address", Order = 1, TypeName = "varchar")]
        public string Address1 { get; set; }

        ///<summary>column:address2</summary>
        [Column("address2", Order = 2, TypeName = "varchar")]
        public string Address2 { get; set; }

        ///<summary>column:district</summary>
        [Required]
        [Column("district", Order = 3, TypeName = "varchar")]
        public string District { get; set; }

        ///<summary>column:city_id</summary>
        [Column("city_id")]
        public short CityId { get; set; }

        ///<summary>column:postal_code</summary>
        [Column("postal_code", Order = 5, TypeName = "varchar")]
        public string PostalCode { get; set; }

        ///<summary>column:phone</summary>
        [Required]
        [Column("phone", Order = 6, TypeName = "varchar")]
        public string Phone { get; set; }

        ///<summary>column:location</summary>
        [Required]
        [Column("location", Order = 7, TypeName = "geometry")]
        public object Location { get; set; }

        ///<summary>column:last_update</summary>
        [Required]
        [Column("last_update", Order = 8, TypeName = "timestamp")]
        public byte[] LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff> Staffs { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store> Stores { get; set; }

        public virtual City City { get; set; }

    }
}
