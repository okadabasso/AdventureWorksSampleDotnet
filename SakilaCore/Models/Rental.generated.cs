using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SakilaCore.Models
{
    [Table("rental")]
    public partial class Rental
    {
        public Rental()
        {
            Payments = new HashSet<Payment>();

        }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Key]
        [Column("rental_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RentalId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("rental_date", Order = 1)]
        public DateTime RentalDate { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Column("inventory_id")]
        public uint InventoryId { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Column("customer_id")]
        public ushort CustomerId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("return_date", Order = 4)]
        public DateTime? ReturnDate { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Column("staff_id")]
        public byte StaffId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("last_update", Order = 6)]
        public DateTime LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Inventory Inventory { get; set; }

        public virtual Staff Staff { get; set; }

    }
}
