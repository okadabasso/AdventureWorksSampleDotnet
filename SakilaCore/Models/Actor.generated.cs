using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SakilaCore.Models
{
    [Table("actor")]
    public partial class Actor
    {
        public Actor()
        {
            FilmActors = new HashSet<FilmActor>();

        }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Key]
        [Column("actor_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ushort ActorId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Required]
        [Column("first_name", Order = 1)]
        [StringLength(45)]
        public string FirstName { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Required]
        [Column("last_name", Order = 2)]
        [StringLength(45)]
        public string LastName { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("last_update", Order = 3)]
        public DateTime LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmActor> FilmActors { get; set; }

    }
}
