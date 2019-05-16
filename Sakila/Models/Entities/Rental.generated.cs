using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sakila.Models
{
    [Table("rental")]
    public partial class Rental
    {
        public Rental()
        {
            Payments = new HashSet<Payment>();

        }

        ///<summary></summary>
        [Key]
        [Column("rental_id", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RentalId { get; set; }

        ///<summary></summary>
        [Column("rental_date", Order = 1, TypeName = "datetime")]
        public DateTime RentalDate { get; set; }

        ///<summary></summary>
        [Column("inventory_id")]
        public int InventoryId { get; set; }

        ///<summary></summary>
        [Column("customer_id")]
        public short CustomerId { get; set; }

        ///<summary></summary>
        [Column("return_date", Order = 4, TypeName = "datetime")]
        public DateTime? ReturnDate { get; set; }

        ///<summary></summary>
        [Column("staff_id")]
        public sbyte StaffId { get; set; }

        ///<summary></summary>
        [Column("last_update", Order = 6, TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Inventory Inventory { get; set; }

        public virtual Staff Staff { get; set; }

    }
}
