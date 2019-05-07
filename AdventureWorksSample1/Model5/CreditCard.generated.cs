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
        public CreditCard()
        {
            CreditCardID = 0;
            CardType = null;
            CardNumber = null;
            ExpMonth = 0;
            ExpYear = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            PersonCreditCards = new HashSet<PersonCreditCard>();
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();

        }

        [Key]
        [Column("CreditCardID", Order = 0, TypeName = "int")]
        public int CreditCardID { get; set; }

        [Required]
        [Column("CardType", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string CardType { get; set; }

        [Required]
        [Column("CardNumber", Order = 2, TypeName = "nvarchar")]
        [StringLength(25)]
        public string CardNumber { get; set; }

        [Column("ExpMonth", Order = 3, TypeName = "tinyint")]
        public byte ExpMonth { get; set; }

        [Column("ExpYear", Order = 4, TypeName = "smallint")]
        public short ExpYear { get; set; }

        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//PersonCreditCard CreditCard
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }

//SalesOrderHeader CreditCard
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

    }
}
