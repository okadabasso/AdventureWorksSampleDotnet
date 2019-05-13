using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("PersonPhone", Schema="Person")]
    public partial class PersonPhone
    {
        public PersonPhone()
        {

        }

        ///<summary>Business entity identification number. Foreign key to Person.BusinessEntityID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("BusinessEntityID", Order = 0)]
        public int BusinessEntityId { get; set; }

        ///<summary>Telephone number identification number.</summary>
        ///<remarks></remarks>
        [Key]
        [Required]
        [Column("PhoneNumber", Order = 1)]
        [StringLength(25)]
        public string PhoneNumber { get; set; }

        ///<summary>Kind of phone number. Foreign key to PhoneNumberType.PhoneNumberTypeID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("PhoneNumberTypeID", Order = 2)]
        public int PhoneNumberTypeId { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 3)]
        public DateTime ModifiedDate { get; set; }

        public virtual Person Person { get; set; }

        public virtual PhoneNumberType PhoneNumberType { get; set; }

    }
}
