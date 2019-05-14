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
            Addresses = new HashSet<Address>();

        }

        ///<summary></summary>
        [Key]
        [Column("city_id", Order = 0, TypeName = "smallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short CityId { get; set; }

        ///<summary></summary>
        [Required]
        [Column("city", Order = 1, TypeName = "varchar")]
        [StringLength(50)]
        public string City1 { get; set; }

        ///<summary></summary>
        [Column("country_id")]
        public short CountryId { get; set; }

        ///<summary></summary>
        [Column("last_update", Order = 3, TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Address> Addresses { get; set; }

        public virtual Country Country { get; set; }

    }
}
