using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Person.PersonPhone")]
    public partial class PersonPhone
    {
        public PersonPhone()
        {
            BusinessEntityId = 0;
            PhoneNumber = null;
            PhoneNumberTypeId = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Business entity identification number. Foreign key to Person.BusinessEntityID.</summary>
        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityId { get; set; }

        ///<summary>Telephone number identification number.</summary>
        [Key]
        [Required]
        [Column("PhoneNumber", Order = 1, TypeName = "nvarchar")]
        [StringLength(25)]
        public string PhoneNumber { get; set; }

        ///<summary>Kind of phone number. Foreign key to PhoneNumberType.PhoneNumberTypeID.</summary>
        [Key]
        [Column("PhoneNumberTypeID", Order = 2, TypeName = "int")]
        public int PhoneNumberTypeId { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Person Person { get; set; }

        public virtual PhoneNumberType PhoneNumberType { get; set; }

    }
}
