using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Sakila.Models
{
    [Table("inventory")]
    public partial class Inventory
    {
        public Inventory()
        {
            InventoryId = null;
            FilmId = 0;
            StoreId = 0;
            LastUpdate = null;
            Rentals = new HashSet<Rental>();

        }

        ///<summary>column:inventory_id</summary>
        [Key]
        [Required]
        [Column("inventory_id", Order = 0, TypeName = "mediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public object InventoryId { get; set; }

        ///<summary>column:film_id</summary>
        [Column("film_id")]
        public short FilmId { get; set; }

        ///<summary>column:store_id</summary>
        [Column("store_id")]
        public byte StoreId { get; set; }

        ///<summary>column:last_update</summary>
        [Required]
        [Column("last_update", Order = 3, TypeName = "timestamp")]
        public byte[] LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rental> Rentals { get; set; }

        public virtual Film Film { get; set; }

        public virtual Store Store { get; set; }

    }
}
