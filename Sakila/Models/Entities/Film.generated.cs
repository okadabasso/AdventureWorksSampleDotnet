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
            FilmId = 0;
            Title = null;
            Description = null;
            ReleaseYear = null;
            LanguageId = 0;
            OriginalLanguageId = null;
            RentalDuration = 0;
            RentalRate = 0;
            Length = null;
            ReplacementCost = 0;
            Rating = null;
            SpecialFeatures = null;
            LastUpdate = null;
            FilmActors = new HashSet<FilmActor>();
            FilmCategories = new HashSet<FilmCategory>();
            Inventories = new HashSet<Inventory>();

        }

        ///<summary>column:film_id</summary>
        [Key]
        [Column("film_id", Order = 0, TypeName = "smallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short FilmId { get; set; }

        ///<summary>column:title</summary>
        [Required]
        [Column("title", Order = 1, TypeName = "varchar")]
        public string Title { get; set; }

        ///<summary>column:description</summary>
        [Column("description", Order = 2, TypeName = "text")]
        public string Description { get; set; }

        ///<summary>column:release_year</summary>
        [Column("release_year", Order = 3, TypeName = "year")]
        public object ReleaseYear { get; set; }

        ///<summary>column:language_id</summary>
        [Column("language_id")]
        public byte LanguageId { get; set; }

        ///<summary>column:original_language_id</summary>
        [Column("original_language_id")]
        public byte? OriginalLanguageId { get; set; }

        ///<summary>column:rental_duration</summary>
        [Column("rental_duration", Order = 6, TypeName = "tinyint")]
        public byte RentalDuration { get; set; }

        ///<summary>column:rental_rate</summary>
        [Column("rental_rate", Order = 7, TypeName = "decimal")]
        public decimal RentalRate { get; set; }

        ///<summary>column:length</summary>
        [Column("length", Order = 8, TypeName = "smallint")]
        public short? Length { get; set; }

        ///<summary>column:replacement_cost</summary>
        [Column("replacement_cost", Order = 9, TypeName = "decimal")]
        public decimal ReplacementCost { get; set; }

        ///<summary>column:rating</summary>
        [Column("rating", Order = 10, TypeName = "enum")]
        public object Rating { get; set; }

        ///<summary>column:special_features</summary>
        [Column("special_features", Order = 11, TypeName = "set")]
        public object SpecialFeatures { get; set; }

        ///<summary>column:last_update</summary>
        [Required]
        [Column("last_update", Order = 12, TypeName = "timestamp")]
        public byte[] LastUpdate { get; set; }


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
