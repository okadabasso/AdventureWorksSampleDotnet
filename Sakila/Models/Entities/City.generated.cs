using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Sakila.Models
{
    [Table("city")]
    public partial class City
    {
        public City()
        {
            CityId = 0;
            City1 = null;
            CountryId = 0;
            LastUpdate = null;
            Addresses = new HashSet<Address>();

        }

        ///<summary>column:city_id</summary>
        [Key]
        [Column("city_id", Order = 0, TypeName = "smallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short CityId { get; set; }

        ///<summary>column:city</summary>
        [Required]
        [Column("city", Order = 1, TypeName = "varchar")]
        public string City1 { get; set; }

        ///<summary>column:country_id</summary>
        [Column("country_id")]
        public short CountryId { get; set; }

        ///<summary>column:last_update</summary>
        [Required]
        [Column("last_update", Order = 3, TypeName = "timestamp")]
        public byte[] LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Address> Addresses { get; set; }

        public virtual Country Country { get; set; }

    }
}
