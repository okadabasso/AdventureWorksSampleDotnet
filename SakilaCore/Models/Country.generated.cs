using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SakilaCore.Models
{
    [Table("country")]
    public partial class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();

        }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Key]
        [Column("country_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ushort CountryId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Required]
        [Column("country", Order = 1)]
        [StringLength(50)]
        public string Country1 { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("last_update", Order = 2)]
        public DateTime LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<City> Cities { get; set; }

    }
}
