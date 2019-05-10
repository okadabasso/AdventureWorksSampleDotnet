using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Sakila.Models
{
    [Table("actor")]
    public partial class Actor
    {
        public Actor()
        {
            ActorId = 0;
            FirstName = null;
            LastName = null;
            LastUpdate = null;
            FilmActors = new HashSet<FilmActor>();

        }

        ///<summary>column:actor_id</summary>
        [Key]
        [Column("actor_id", Order = 0, TypeName = "smallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short ActorId { get; set; }

        ///<summary>column:first_name</summary>
        [Required]
        [Column("first_name", Order = 1, TypeName = "varchar")]
        public string FirstName { get; set; }

        ///<summary>column:last_name</summary>
        [Required]
        [Column("last_name", Order = 2, TypeName = "varchar")]
        public string LastName { get; set; }

        ///<summary>column:last_update</summary>
        [Required]
        [Column("last_update", Order = 3, TypeName = "timestamp")]
        public byte[] LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmActor> FilmActors { get; set; }

    }
}
