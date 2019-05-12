using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Sakila.Models
{
    [Table("payment")]
    public partial class Payment
    {
        public Payment()
        {

        }

        ///<summary></summary>
        [Key]
        [Column("payment_id", Order = 0, TypeName = "smallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short PaymentId { get; set; }

        ///<summary></summary>
        [Column("customer_id")]
        public short CustomerId { get; set; }

        ///<summary></summary>
        [Column("staff_id")]
        public sbyte StaffId { get; set; }

        ///<summary></summary>
        [Column("rental_id")]
        public int? RentalId { get; set; }

        ///<summary></summary>
        [Column("amount", Order = 4, TypeName = "decimal")]
        public decimal Amount { get; set; }

        ///<summary></summary>
        [Column("payment_date", Order = 5, TypeName = "datetime")]
        public DateTime PaymentDate { get; set; }

        ///<summary></summary>
        [Column("last_update", Order = 6, TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Rental Rental { get; set; }

        public virtual Staff Staff { get; set; }

    }
}
