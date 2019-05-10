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
            CountryId = 0;
            Country1 = null;
            LastUpdate = null;
            Cities = new HashSet<City>();

        }

        ///<summary>column:country_id</summary>
        [Key]
        [Column("country_id", Order = 0, TypeName = "smallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short CountryId { get; set; }

        ///<summary>column:country</summary>
        [Required]
        [Column("country", Order = 1, TypeName = "varchar")]
        public string Country1 { get; set; }

        ///<summary>column:last_update</summary>
        [Required]
        [Column("last_update", Order = 2, TypeName = "timestamp")]
        public byte[] LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<City> Cities { get; set; }

    }
}
