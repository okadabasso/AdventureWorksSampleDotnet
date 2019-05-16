using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sakila.Models
{
    [Table("category")]
    public partial class Category
    {
        public Category()
        {
            FilmCategories = new HashSet<FilmCategory>();

        }

        ///<summary></summary>
        [Key]
        [Column("category_id", Order = 0, TypeName = "tinyint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public sbyte CategoryId { get; set; }

        ///<summary></summary>
        [Required]
        [Column("name", Order = 1, TypeName = "varchar")]
        [StringLength(25)]
        public string Name { get; set; }

        ///<summary></summary>
        [Column("last_update", Order = 2, TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmCategory> FilmCategories { get; set; }

    }
}
