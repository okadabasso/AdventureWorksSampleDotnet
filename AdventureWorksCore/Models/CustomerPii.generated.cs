using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("CustomerPII", Schema="Sales")]
    public partial class CustomerPii
    {
        public CustomerPii()
        {

        }

        ///<summary>column:CustomerID</summary>
        ///<remarks></remarks>
        [Key]
        [Column("CustomerID", Order = 0)]
        public int CustomerId { get; set; }

        ///<summary>column:FirstName</summary>
        ///<remarks></remarks>
        [Required]
        [Column("FirstName", Order = 1)]
        [StringLength(50)]
        public string FirstName { get; set; }

        ///<summary>column:LastName</summary>
        ///<remarks></remarks>
        [Required]
        [Column("LastName", Order = 2)]
        [StringLength(50)]
        public string LastName { get; set; }

        ///<summary>column:SSN</summary>
        ///<remarks></remarks>
        [Column("SSN", Order = 3)]
        [StringLength(11)]
        public string Ssn { get; set; }

        ///<summary>column:CreditCardNumber</summary>
        ///<remarks></remarks>
        [Column("CreditCardNumber", Order = 4)]
        [StringLength(25)]
        public string CreditCardNumber { get; set; }

        ///<summary>column:EmailAddress</summary>
        ///<remarks></remarks>
        [Column("EmailAddress", Order = 5)]
        [StringLength(50)]
        public string EmailAddress { get; set; }

        ///<summary>column:PhoneNumber</summary>
        ///<remarks></remarks>
        [Column("PhoneNumber", Order = 6)]
        [StringLength(25)]
        public string PhoneNumber { get; set; }

        ///<summary>column:TerritoryID</summary>
        ///<remarks></remarks>
        [Column("TerritoryID", Order = 7)]
        public int? TerritoryId { get; set; }

    }
}
