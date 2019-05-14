using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Sakila.Models
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
        [Key]
        [Column("film_id", Order = 0, TypeName = "smallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

        ///<summary></summary>
        [Column("release_year", Order = 3, TypeName = "year")]
        public object ReleaseYear { get; set; }

        ///<summary></summary>
        [Column("language_id")]
        public sbyte LanguageId { get; set; }

        ///<summary></summary>
        [Column("original_language_id")]
        public sbyte? OriginalLanguageId { get; set; }

        ///<summary></summary>
        [Column("rental_duration", Order = 6, TypeName = "tinyint")]
        public sbyte RentalDuration { get; set; }

        ///<summary></summary>
        [Column("rental_rate", Order = 7, TypeName = "decimal")]
        public decimal RentalRate { get; set; }

        ///<summary></summary>
        [Column("length", Order = 8, TypeName = "smallint")]
        public short? Length { get; set; }

        ///<summary></summary>
        [Column("replacement_cost", Order = 9, TypeName = "decimal")]
        public decimal ReplacementCost { get; set; }

        ///<summary></summary>
        [Column("rating", Order = 10, TypeName = "enum")]
        public object Rating { get; set; }

        ///<summary></summary>
        [Column("special_features", Order = 11, TypeName = "set")]
        public object SpecialFeatures { get; set; }

        ///<summary></summary>
        [Column("last_update", Order = 12, TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmActor> FilmActors { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmCategory> FilmCategories { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory> Inventories { get; set; }

        public virtual Language Language { get; set; }

        public virtual Language OriginalLanguage { get; set; }

    }
}
