using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.PersonCreditCard")]
    public partial class PersonCreditCard
    {
        [Key]
        [Column("BusinessEntityID", Order = 1, TypeName = "int")]
        public int BusinessEntityId { get; set; }
        [Key]
        [Column("CreditCardID", Order = 2, TypeName = "int")]
        public int CreditCardId { get; set; }
        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public PersonCreditCard()
        {
            BusinessEntityId = 0;
            CreditCardId = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
