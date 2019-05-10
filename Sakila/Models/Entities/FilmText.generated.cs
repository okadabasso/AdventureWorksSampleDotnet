using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Sakila.Models
{
    [Table("film_text")]
    public partial class FilmText
    {
        public FilmText()
        {
            FilmId = 0;
            Title = null;
            Description = null;

        }

        ///<summary>column:film_id</summary>
        [Key]
        [Column("film_id", Order = 0, TypeName = "smallint")]
        public short FilmId { get; set; }

        ///<summary>column:title</summary>
        [Required]
        [Column("title", Order = 1, TypeName = "varchar")]
        public string Title { get; set; }

        ///<summary>column:description</summary>
        [Column("description", Order = 2, TypeName = "text")]
        public string Description { get; set; }

    }
}
