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
        public PersonCreditCard()
        {
            BusinessEntityID = 0;
            CreditCardID = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityID { get; set; }

        [Key]
        [Column("CreditCardID", Order = 1, TypeName = "int")]
        public int CreditCardID { get; set; }

        [Column("ModifiedDate", Order = 2, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual CreditCard CreditCard { get; set; }

        public virtual Person Person { get; set; }

    }
}
