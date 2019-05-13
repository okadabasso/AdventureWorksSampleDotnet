using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SakilaCore.Models
{
    [Table("category")]
    public partial class Category
    {
        public Category()
        {
            FilmCategories = new HashSet<FilmCategory>();

        }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Key]
        [Column("category_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte CategoryId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Required]
        [Column("name", Order = 1)]
        [StringLength(25)]
        public string Name { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("last_update", Order = 2)]
        public DateTime LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmCategory> FilmCategories { get; set; }

    }
}
