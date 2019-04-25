using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.CreditCard")]
    public partial class CreditCard
    {
        [Key]
        [Column("CreditCardID", Order = 1, TypeName = "int")]
        public int CreditCardId { get; set; }
        [Column("CardType", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string CardType { get; set; }
        [Column("CardNumber", Order = 3, TypeName = "nvarchar")]
        [StringLength(25)]
        public string CardNumber { get; set; }
        [Column("ExpMonth", Order = 4, TypeName = "tinyint")]
        public byte ExpMonth { get; set; }
        [Column("ExpYear", Order = 5, TypeName = "smallint")]
        public short ExpYear { get; set; }
        [Column("ModifiedDate", Order = 6, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public CreditCard()
        {
            CreditCardId = 0;
            CardType = null;
            CardNumber = null;
            ExpMonth = 0;
            ExpYear = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
