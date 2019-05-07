using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.CustomerPII")]
    public partial class CustomerPII
    {
        public CustomerPII()
        {
            CustomerID = 0;
            FirstName = null;
            LastName = null;
            SSN = null;
            CreditCardNumber = null;
            EmailAddress = null;
            PhoneNumber = null;
            TerritoryID = null;


        }

        [Key]
        [Column("CustomerID", Order = 0, TypeName = "int")]
        public int CustomerID { get; set; }

        [Required]
        [Column("FirstName", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Column("LastName", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Column("SSN", Order = 3, TypeName = "nvarchar")]
        [StringLength(11)]
        public string SSN { get; set; }

        [Column("CreditCardNumber", Order = 4, TypeName = "nvarchar")]
        [StringLength(25)]
        public string CreditCardNumber { get; set; }

        [Column("EmailAddress", Order = 5, TypeName = "nvarchar")]
        [StringLength(50)]
        public string EmailAddress { get; set; }

        [Column("PhoneNumber", Order = 6, TypeName = "nvarchar")]
        [StringLength(25)]
        public string PhoneNumber { get; set; }

        [Column("TerritoryID", Order = 7, TypeName = "int")]
        public int? TerritoryID { get; set; }

    }
}
