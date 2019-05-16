using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SakilaCore.Models
{
    [Table("payment", Schema="sakila")]
    public partial class Payment
    {
        public Payment()
        {

        }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Key]
        [Column("payment_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ushort PaymentId { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Column("customer_id")]
        public ushort CustomerId { get; set; }

        ///<summary></summary>
        ///<remarks>YES</remarks>
        [Column("staff_id")]
        public byte StaffId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("rental_id")]
        public int? RentalId { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("amount", Order = 4)]
        public decimal Amount { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("payment_date", Order = 5)]
        public DateTime PaymentDate { get; set; }

        ///<summary></summary>
        ///<remarks>NO</remarks>
        [Column("last_update", Order = 6)]
        public DateTime? LastUpdate { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Rental Rental { get; set; }

        public virtual Staff Staff { get; set; }

    }
}
