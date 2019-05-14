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
            FilmActors = new HashSet<FilmActor>();

        }

        ///<summary></summary>
        [Key]
        [Column("actor_id", Order = 0, TypeName = "smallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short ActorId { get; set; }

        ///<summary></summary>
        [Required]
        [Column("first_name", Order = 1, TypeName = "varchar")]
        [StringLength(45)]
        public string FirstName { get; set; }

        ///<summary></summary>
        [Required]
        [Column("last_name", Order = 2, TypeName = "varchar")]
        [StringLength(45)]
        public string LastName { get; set; }

        ///<summary></summary>
        [Column("last_update", Order = 3, TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmActor> FilmActors { get; set; }

    }
}
