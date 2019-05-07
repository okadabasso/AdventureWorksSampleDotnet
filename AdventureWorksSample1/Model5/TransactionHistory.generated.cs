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
            TransactionID = 0;
            ProductID = 0;
            ReferenceOrderID = 0;
            ReferenceOrderLineID = 0;
            TransactionDate = DateTime.Parse("0001/01/01 0:00:00");
            TransactionType = null;
            Quantity = 0;
            ActualCost = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("TransactionID", Order = 0, TypeName = "int")]
        public int TransactionID { get; set; }

        public int ProductID { get; set; }

        [Column("ReferenceOrderID", Order = 2, TypeName = "int")]
        public int ReferenceOrderID { get; set; }

        [Column("ReferenceOrderLineID", Order = 3, TypeName = "int")]
        public int ReferenceOrderLineID { get; set; }

        [Column("TransactionDate", Order = 4, TypeName = "datetime")]
        public DateTime TransactionDate { get; set; }

        [Required]
        [Column("TransactionType", Order = 5, TypeName = "nchar")]
        [StringLength(1)]
        public string TransactionType { get; set; }

        [Column("Quantity", Order = 6, TypeName = "int")]
        public int Quantity { get; set; }

        [Column("ActualCost", Order = 7, TypeName = "money")]
        public decimal ActualCost { get; set; }

        [Column("ModifiedDate", Order = 8, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

    }
}
