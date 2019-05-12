using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Sakila.Models
{
    [Table("language")]
    public partial class Language
    {
        public Language()
        {
            Films = new HashSet<Film>();
            Films1 = new HashSet<Film>();

        }

        ///<summary></summary>
        [Key]
        [Column("language_id", Order = 0, TypeName = "tinyint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public sbyte LanguageId { get; set; }

        ///<summary></summary>
        [Required]
        [Column("name", Order = 1, TypeName = "char")]
        [StringLength(20)]
        public string Name { get; set; }

        ///<summary></summary>
        [Column("last_update", Order = 2, TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Film> Films { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Film> Films1 { get; set; }

    }
}
