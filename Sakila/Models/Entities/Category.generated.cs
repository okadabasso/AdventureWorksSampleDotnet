using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Sakila.Models
{
    [Table("category")]
    public partial class Category
    {
        public Category()
        {
            CategoryId = 0;
            Name = null;
            LastUpdate = null;
            FilmCategories = new HashSet<FilmCategory>();

        }

        ///<summary>column:category_id</summary>
        [Key]
        [Column("category_id", Order = 0, TypeName = "tinyint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte CategoryId { get; set; }

        ///<summary>column:name</summary>
        [Required]
        [Column("name", Order = 1, TypeName = "varchar")]
        public string Name { get; set; }

        ///<summary>column:last_update</summary>
        [Required]
        [Column("last_update", Order = 2, TypeName = "timestamp")]
        public byte[] LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmCategory> FilmCategories { get; set; }

    }
}
