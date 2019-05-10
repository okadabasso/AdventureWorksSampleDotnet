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
            PaymentId = 0;
            CustomerId = 0;
            StaffId = 0;
            RentalId = null;
            Amount = 0;
            PaymentDate = DateTime.Parse("0001/01/01 0:00:00");
            LastUpdate = null;

        }

        ///<summary>column:payment_id</summary>
        [Key]
        [Column("payment_id", Order = 0, TypeName = "smallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short PaymentId { get; set; }

        ///<summary>column:customer_id</summary>
        [Column("customer_id")]
        public short CustomerId { get; set; }

        ///<summary>column:staff_id</summary>
        [Column("staff_id")]
        public byte StaffId { get; set; }

        ///<summary>column:rental_id</summary>
        [Column("rental_id")]
        public int? RentalId { get; set; }

        ///<summary>column:amount</summary>
        [Column("amount", Order = 4, TypeName = "decimal")]
        public decimal Amount { get; set; }

        ///<summary>column:payment_date</summary>
        [Column("payment_date", Order = 5, TypeName = "datetime")]
        public DateTime PaymentDate { get; set; }

        ///<summary>column:last_update</summary>
        [Column("last_update", Order = 6, TypeName = "timestamp")]
        public byte[] LastUpdate { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Rental Rental { get; set; }

        public virtual Staff Staff { get; set; }

    }
}
