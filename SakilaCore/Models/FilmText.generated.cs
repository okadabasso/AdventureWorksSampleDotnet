using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SakilaCore.Models
{
    [Table("film_text")]
    public partial class FilmText
    {
        public FilmText()
        {

        }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Key]
        [Column("film_id", Order = 0)]
        public short FilmId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Required]
        [Column("title", Order = 1)]
        [StringLength(255)]
        public string Title { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("description", Order = 2)]
        [StringLength(65535)]
        public string Description { get; set; }

    }
}
