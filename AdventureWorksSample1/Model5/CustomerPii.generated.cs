using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.CustomerPII")]
    public partial class CustomerPii
    {
        [Key]
        [Column("CustomerID", Order = 1, TypeName = "int")]
        public int CustomerId { get; set; }
        [Column("FirstName", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Column("LastName", Order = 3, TypeName = "nvarchar")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Column("SSN", Order = 4, TypeName = "nvarchar")]
        [StringLength(11)]
        public string Ssn { get; set; }
        [Column("CreditCardNumber", Order = 5, TypeName = "nvarchar")]
        [StringLength(25)]
        public string CreditCardNumber { get; set; }
        [Column("EmailAddress", Order = 6, TypeName = "nvarchar")]
        [StringLength(50)]
        public string EmailAddress { get; set; }
        [Column("PhoneNumber", Order = 7, TypeName = "nvarchar")]
        [StringLength(25)]
        public string PhoneNumber { get; set; }
        [Column("TerritoryID", Order = 8, TypeName = "int")]
        public int? TerritoryId { get; set; }
        public CustomerPii()
        {
            CustomerId = 0;
            FirstName = null;
            LastName = null;
            Ssn = null;
            CreditCardNumber = null;
            EmailAddress = null;
            PhoneNumber = null;
            TerritoryId = null;
        }
    }
}
