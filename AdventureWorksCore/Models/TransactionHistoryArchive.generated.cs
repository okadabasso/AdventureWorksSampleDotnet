using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("TransactionHistoryArchive", Schema="Production")]
    public partial class TransactionHistoryArchive
    {
        public TransactionHistoryArchive()
        {

        }

        ///<summary>Primary key for TransactionHistoryArchive records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("TransactionID", Order = 0)]
        public int TransactionId { get; set; }

        ///<summary>Product identification number. Foreign key to Product.ProductID.</summary>
        ///<remarks></remarks>
        [Column("ProductID", Order = 1)]
        public int ProductId { get; set; }

        ///<summary>Purchase order, sales order, or work order identification number.</summary>
        ///<remarks></remarks>
        [Column("ReferenceOrderID", Order = 2)]
        public int ReferenceOrderId { get; set; }

        ///<summary>Line number associated with the purchase order, sales order, or work order.</summary>
        ///<remarks></remarks>
        [Column("ReferenceOrderLineID", Order = 3)]
        public int ReferenceOrderLineId { get; set; }

        ///<summary>Date and time of the transaction.</summary>
        ///<remarks></remarks>
        [Column("TransactionDate", Order = 4)]
        public DateTime TransactionDate { get; set; }

        ///<summary>W = Work Order, S = Sales Order, P = Purchase Order</summary>
        ///<remarks></remarks>
        [Required]
        [Column("TransactionType", Order = 5)]
        [StringLength(1)]
        public string TransactionType { get; set; }

        ///<summary>Product quantity.</summary>
        ///<remarks></remarks>
        [Column("Quantity", Order = 6)]
        public int Quantity { get; set; }

        ///<summary>Product cost.</summary>
        ///<remarks></remarks>
        [Column("ActualCost", Order = 7)]
        public decimal ActualCost { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 8)]
        public DateTime ModifiedDate { get; set; }

    }
}
