using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Sales.PersonCreditCard")]
    public partial class PersonCreditCard
    {
        public PersonCreditCard()
        {
            BusinessEntityId = 0;
            CreditCardId = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Business entity identification number. Foreign key to Person.BusinessEntityID.</summary>
        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityId { get; set; }

        ///<summary>Credit card identification number. Foreign key to CreditCard.CreditCardID.</summary>
        [Key]
        [Column("CreditCardID", Order = 1, TypeName = "int")]
        public int CreditCardId { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 2, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual CreditCard CreditCard { get; set; }

        public virtual Person Person { get; set; }

    }
}
