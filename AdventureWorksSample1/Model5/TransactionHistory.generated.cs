using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.TransactionHistory")]
    public partial class TransactionHistory
    {
        public TransactionHistory()
        {
            TransactionId = 0;
            ProductId = 0;
            ReferenceOrderId = 0;
            ReferenceOrderLineId = 0;
            TransactionDate = DateTime.Parse("0001/01/01 0:00:00");
            TransactionType = null;
            Quantity = 0;
            ActualCost = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Primary key for TransactionHistory records.</summary>
        [Key]
        [Column("TransactionID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }

        ///<summary>Product identification number. Foreign key to Product.ProductID.</summary>
        public int ProductId { get; set; }

        ///<summary>Purchase order, sales order, or work order identification number.</summary>
        [Column("ReferenceOrderID", Order = 2, TypeName = "int")]
        public int ReferenceOrderId { get; set; }

        ///<summary>Line number associated with the purchase order, sales order, or work order.</summary>
        [Column("ReferenceOrderLineID", Order = 3, TypeName = "int")]
        public int ReferenceOrderLineId { get; set; }

        ///<summary>Date and time of the transaction.</summary>
        [Column("TransactionDate", Order = 4, TypeName = "datetime")]
        public DateTime TransactionDate { get; set; }

        ///<summary>W = WorkOrder, S = SalesOrder, P = PurchaseOrder</summary>
        [Required]
        [Column("TransactionType", Order = 5, TypeName = "nchar")]
        [StringLength(1)]
        public string TransactionType { get; set; }

        ///<summary>Product quantity.</summary>
        [Column("Quantity", Order = 6, TypeName = "int")]
        public int Quantity { get; set; }

        ///<summary>Product cost.</summary>
        [Column("ActualCost", Order = 7, TypeName = "money")]
        public decimal ActualCost { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 8, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

    }
}
