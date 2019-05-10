using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Sakila.Models
{
    [Table("rental")]
    public partial class Rental
    {
        public Rental()
        {
            RentalId = 0;
            RentalDate = DateTime.Parse("0001/01/01 0:00:00");
            InventoryId = null;
            CustomerId = 0;
            ReturnDate = null;
            StaffId = 0;
            LastUpdate = null;
            Payments = new HashSet<Payment>();

        }

        ///<summary>column:rental_id</summary>
        [Key]
        [Column("rental_id", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RentalId { get; set; }

        ///<summary>column:rental_date</summary>
        [Column("rental_date", Order = 1, TypeName = "datetime")]
        public DateTime RentalDate { get; set; }

        ///<summary>column:inventory_id</summary>
        [Required]
        [Column("inventory_id")]
        public object InventoryId { get; set; }

        ///<summary>column:customer_id</summary>
        [Column("customer_id")]
        public short CustomerId { get; set; }

        ///<summary>column:return_date</summary>
        [Column("return_date", Order = 4, TypeName = "datetime")]
        public DateTime? ReturnDate { get; set; }

        ///<summary>column:staff_id</summary>
        [Column("staff_id")]
        public byte StaffId { get; set; }

        ///<summary>column:last_update</summary>
        [Required]
        [Column("last_update", Order = 6, TypeName = "timestamp")]
        public byte[] LastUpdate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Inventory Inventory { get; set; }

        public virtual Staff Staff { get; set; }

    }
}
