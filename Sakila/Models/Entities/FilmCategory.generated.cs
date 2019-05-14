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

        }

        ///<summary></summary>
        [Key]
        [Column("film_id", Order = 0, TypeName = "smallint")]
        public short FilmId { get; set; }

        ///<summary></summary>
        [Key]
        [Column("category_id", Order = 1, TypeName = "tinyint")]
        public sbyte CategoryId { get; set; }

        ///<summary></summary>
        [Column("last_update", Order = 2, TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }

        public virtual Category Category { get; set; }

        public virtual Film Film { get; set; }

    }
}
