using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sakila.Models
{
    [Table("film_text")]
    public partial class FilmText
    {
        public FilmText()
        {

        }

        ///<summary></summary>
        [Key]
        [Column("film_id", Order = 0, TypeName = "smallint")]
        public short FilmId { get; set; }

        ///<summary></summary>
        [Required]
        [Column("title", Order = 1, TypeName = "varchar")]
        [StringLength(255)]
        public string Title { get; set; }

        ///<summary></summary>
        [Column("description", Order = 2, TypeName = "text")]
        [StringLength(65535)]
        public string Description { get; set; }

    }
}
