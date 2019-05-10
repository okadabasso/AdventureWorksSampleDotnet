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
            ActorId = 0;
            FilmId = 0;
            LastUpdate = null;

        }

        ///<summary>column:actor_id</summary>
        [Key]
        [Column("actor_id", Order = 0, TypeName = "smallint")]
        public short ActorId { get; set; }

        ///<summary>column:film_id</summary>
        [Key]
        [Column("film_id", Order = 1, TypeName = "smallint")]
        public short FilmId { get; set; }

        ///<summary>column:last_update</summary>
        [Required]
        [Column("last_update", Order = 2, TypeName = "timestamp")]
        public byte[] LastUpdate { get; set; }

        public virtual Actor Actor { get; set; }

        public virtual Film Film { get; set; }

    }
}
