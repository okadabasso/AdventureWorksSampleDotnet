using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Sakila.Models
{
    [Table("film_actor")]
    public partial class FilmActor
    {
        public FilmActor()
        {

        }

        ///<summary></summary>
        [Key]
        [Column("actor_id", Order = 0)]
        public short ActorId { get; set; }

        ///<summary></summary>
        [Key]
        [Column("film_id", Order = 1)]
        public short FilmId { get; set; }
                ///<summary></summary>
        [Column("last_update", Order = 2, TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }

        public virtual Actor Actor { get; set; }

        public virtual Film Film { get; set; }

    }
}
