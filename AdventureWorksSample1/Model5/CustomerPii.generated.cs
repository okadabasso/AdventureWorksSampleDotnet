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

        ///<summary>column:CustomerID</summary>
        [Key]
        [Column("CustomerID", Order = 0, TypeName = "int")]
        public int CustomerId { get; set; }

        ///<summary>column:FirstName</summary>
        [Required]
        [Column("FirstName", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string FirstName { get; set; }

        ///<summary>column:LastName</summary>
        [Required]
        [Column("LastName", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string LastName { get; set; }

        ///<summary>column:SSN</summary>
        [Column("SSN", Order = 3, TypeName = "nvarchar")]
        [StringLength(11)]
        public string Ssn { get; set; }

        ///<summary>column:CreditCardNumber</summary>
        [Column("CreditCardNumber", Order = 4, TypeName = "nvarchar")]
        [StringLength(25)]
        public string CreditCardNumber { get; set; }

        ///<summary>column:EmailAddress</summary>
        [Column("EmailAddress", Order = 5, TypeName = "nvarchar")]
        [StringLength(50)]
        public string EmailAddress { get; set; }

        ///<summary>column:PhoneNumber</summary>
        [Column("PhoneNumber", Order = 6, TypeName = "nvarchar")]
        [StringLength(25)]
        public string PhoneNumber { get; set; }

        ///<summary>column:TerritoryID</summary>
        [Column("TerritoryID", Order = 7, TypeName = "int")]
        public int? TerritoryId { get; set; }

    }
}
