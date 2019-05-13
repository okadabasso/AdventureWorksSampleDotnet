using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SakilaCore.Models
{
    [Table("inventory")]
    public partial class Inventory
    {
        public Inventory()
        {
            Rentals = new HashSet<Rental>();

        }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Key]
        [Column("inventory_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint InventoryId { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Column("film_id")]
        public ushort FilmId { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Column("store_id")]
        public byte StoreId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("last_update", Order = 3)]
        public DateTime LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rental> Rentals { get; set; }

        public virtual Film Film { get; set; }

        public virtual Store Store { get; set; }

    }
}
