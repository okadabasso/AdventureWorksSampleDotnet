using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SakilaCore.Models
{
    [Table("film_actor")]
    public partial class FilmActor
    {
        public FilmActor()
        {

        }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Key]
        [Column("actor_id", Order = 0)]
        public ushort ActorId { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Key]
        [Column("film_id", Order = 1)]
        public ushort FilmId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("last_update", Order = 2)]
        public DateTime LastUpdate { get; set; }

        public virtual Actor Actor { get; set; }

        public virtual Film Film { get; set; }

    }
}
