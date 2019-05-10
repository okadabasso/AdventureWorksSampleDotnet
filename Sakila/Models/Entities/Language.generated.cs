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
            LanguageId = 0;
            Name = null;
            LastUpdate = null;
            Films = new HashSet<Film>();
            Films1 = new HashSet<Film>();

        }

        ///<summary>column:language_id</summary>
        [Key]
        [Column("language_id", Order = 0, TypeName = "tinyint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte LanguageId { get; set; }

        ///<summary>column:name</summary>
        [Required]
        [Column("name", Order = 1, TypeName = "char")]
        public string Name { get; set; }

        ///<summary>column:last_update</summary>
        [Required]
        [Column("last_update", Order = 2, TypeName = "timestamp")]
        public byte[] LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Film> Films { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Film> Films1 { get; set; }

    }
}
