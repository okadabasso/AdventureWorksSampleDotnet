using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("PersonCreditCard", Schema="Sales")]
    public partial class PersonCreditCard
    {
        public PersonCreditCard()
        {

        }

        ///<summary>Business entity identification number. Foreign key to Person.BusinessEntityID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("BusinessEntityID", Order = 0)]
        public int BusinessEntityId { get; set; }

        ///<summary>Credit card identification number. Foreign key to CreditCard.CreditCardID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("CreditCardID", Order = 1)]
        public int CreditCardId { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 2)]
        public DateTime ModifiedDate { get; set; }

        public virtual CreditCard CreditCard { get; set; }

        public virtual Person Person { get; set; }

    }
}
