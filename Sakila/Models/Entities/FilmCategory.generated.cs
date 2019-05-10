using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Sakila.Models
{
    [Table("film_category")]
    public partial class FilmCategory
    {
        public FilmCategory()
        {
            FilmId = 0;
            CategoryId = 0;
            LastUpdate = null;

        }

        ///<summary>column:film_id</summary>
        [Key]
        [Column("film_id", Order = 0, TypeName = "smallint")]
        public short FilmId { get; set; }

        ///<summary>column:category_id</summary>
        [Key]
        [Column("category_id", Order = 1, TypeName = "tinyint")]
        public byte CategoryId { get; set; }

        ///<summary>column:last_update</summary>
        [Required]
        [Column("last_update", Order = 2, TypeName = "timestamp")]
        public byte[] LastUpdate { get; set; }

        public virtual Category Category { get; set; }

        public virtual Film Film { get; set; }

    }
}
