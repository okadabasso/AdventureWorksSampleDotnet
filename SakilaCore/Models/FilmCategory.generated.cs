using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SakilaCore.Models
{
    [Table("film_category")]
    public partial class FilmCategory
    {
        public FilmCategory()
        {

        }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Key]
        [Column("film_id", Order = 0)]
        public ushort FilmId { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Key]
        [Column("category_id", Order = 1)]
        public byte CategoryId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("last_update", Order = 2)]
        public DateTime LastUpdate { get; set; }

        public virtual Category Category { get; set; }

        public virtual Film Film { get; set; }

    }
}
