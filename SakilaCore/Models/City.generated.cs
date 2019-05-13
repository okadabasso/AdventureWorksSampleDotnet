using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SakilaCore.Models
{
    [Table("city")]
    public partial class City
    {
        public City()
        {
            Addresses = new HashSet<Address>();

        }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Key]
        [Column("city_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ushort CityId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Required]
        [Column("city", Order = 1)]
        [StringLength(50)]
        public string City1 { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Column("country_id")]
        public ushort CountryId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("last_update", Order = 3)]
        public DateTime LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Address> Addresses { get; set; }

        public virtual Country Country { get; set; }

    }
}
