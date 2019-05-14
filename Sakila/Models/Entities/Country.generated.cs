using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Sakila.Models
{
    [Table("country")]
    public partial class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();

        }

        ///<summary></summary>
        [Key]
        [Column("country_id", Order = 0, TypeName = "smallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short CountryId { get; set; }

        ///<summary></summary>
        [Required]
        [Column("country", Order = 1, TypeName = "varchar")]
        [StringLength(50)]
        public string Country1 { get; set; }

        ///<summary></summary>
        [Column("last_update", Order = 2, TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<City> Cities { get; set; }

    }
}
