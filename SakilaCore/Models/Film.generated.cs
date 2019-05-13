using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SakilaCore.Models
{
    [Table("film")]
    public partial class Film
    {
        public Film()
        {
            FilmActors = new HashSet<FilmActor>();
            FilmCategories = new HashSet<FilmCategory>();
            Inventories = new HashSet<Inventory>();

        }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Key]
        [Column("film_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ushort FilmId { get; set; }

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

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("release_year", Order = 3)]
        public int? ReleaseYear { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Column("language_id")]
        public byte LanguageId { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Column("original_language_id")]
        public byte? OriginalLanguageId { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Column("rental_duration", Order = 6)]
        public byte RentalDuration { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("rental_rate", Order = 7)]
        public decimal RentalRate { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Column("length", Order = 8)]
        public ushort? Length { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("replacement_cost", Order = 9)]
        public decimal ReplacementCost { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("last_update", Order = 12)]
        public DateTime LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmActor> FilmActors { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmCategory> FilmCategories { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory> Inventories { get; set; }

        public virtual Language Language { get; set; }

        public virtual Language Language1 { get; set; }

    }
}
