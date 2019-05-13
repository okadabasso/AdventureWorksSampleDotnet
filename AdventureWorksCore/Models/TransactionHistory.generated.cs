using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("TransactionHistory", Schema="Production")]
    public partial class TransactionHistory
    {
        public TransactionHistory()
        {

        }

        ///<summary>Primary key for TransactionHistory records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("TransactionID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }

        ///<summary>Product identification number. Foreign key to Product.ProductID.</summary>
        ///<remarks></remarks>
        [Column("ProductID")]
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

        ///<summary>W = WorkOrder, S = SalesOrder, P = PurchaseOrder</summary>
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

        public virtual Product Product { get; set; }

    }
}
