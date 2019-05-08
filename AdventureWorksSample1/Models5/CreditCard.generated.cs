using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Sales.CreditCard")]
    public partial class CreditCard
    {
        public CreditCard()
        {
            CreditCardId = 0;
            CardType = null;
            CardNumber = null;
            ExpMonth = 0;
            ExpYear = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            PersonCreditCards = new HashSet<PersonCreditCard>();
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();

        }

        ///<summary>Primary key for CreditCard records.</summary>
        [Key]
        [Column("CreditCardID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CreditCardId { get; set; }

        ///<summary>Credit card name.</summary>
        [Required]
        [Column("CardType", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string CardType { get; set; }

        ///<summary>Credit card number.</summary>
        [Required]
        [Column("CardNumber", Order = 2, TypeName = "nvarchar")]
        [StringLength(25)]
        public string CardNumber { get; set; }

        ///<summary>Credit card expiration month.</summary>
        [Column("ExpMonth", Order = 3, TypeName = "tinyint")]
        public byte ExpMonth { get; set; }

        ///<summary>Credit card expiration year.</summary>
        [Column("ExpYear", Order = 4, TypeName = "smallint")]
        public short ExpYear { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

    }
}
