using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.TransactionHistoryArchive")]
    public partial class TransactionHistoryArchive
    {
        [Key]
        [Column("TransactionID", Order = 1, TypeName = "int")]
        public int TransactionId { get; set; }
        [Column("ProductID", Order = 2, TypeName = "int")]
        public int ProductId { get; set; }
        [Column("ReferenceOrderID", Order = 3, TypeName = "int")]
        public int ReferenceOrderId { get; set; }
        [Column("ReferenceOrderLineID", Order = 4, TypeName = "int")]
        public int ReferenceOrderLineId { get; set; }
        [Column("TransactionDate", Order = 5, TypeName = "datetime")]
        public DateTime TransactionDate { get; set; }
        [Column("TransactionType", Order = 6, TypeName = "nchar")]
        [StringLength(1)]
        public string TransactionType { get; set; }
        [Column("Quantity", Order = 7, TypeName = "int")]
        public int Quantity { get; set; }
        [Column("ActualCost", Order = 8, TypeName = "money")]
        public decimal ActualCost { get; set; }
        [Column("ModifiedDate", Order = 9, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public TransactionHistoryArchive()
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
    }
}
