using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SakilaCore.Models
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
        ///<remarks>YES</remarks>
        [Key]
        [Column("language_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte LanguageId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Required]
        [Column("name", Order = 1)]
        [StringLength(20)]
        public string Name { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("last_update", Order = 2)]
        public DateTime LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Film> Films { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Film> Films1 { get; set; }

    }
}
