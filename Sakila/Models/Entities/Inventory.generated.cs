using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sakila.Models
{
    [Table("inventory")]
    public partial class Inventory
    {
        public Inventory()
        {
            Rentals = new HashSet<Rental>();

        }

        ///<summary></summary>
        [Key]
        [Column("inventory_id", Order = 0, TypeName = "mediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InventoryId { get; set; }

        ///<summary></summary>
        [Column("film_id")]
        public short FilmId { get; set; }

        ///<summary></summary>
        [Column("store_id")]
        public sbyte StoreId { get; set; }

        ///<summary></summary>
        [Column("last_update", Order = 3, TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rental> Rentals { get; set; }

        public virtual Film Film { get; set; }

        public virtual Store Store { get; set; }

    }
}
