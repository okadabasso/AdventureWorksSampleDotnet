using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Person.PersonPhone")]
    public partial class PersonPhone
    {
        public PersonPhone()
        {
            BusinessEntityID = 0;
            PhoneNumber = null;
            PhoneNumberTypeID = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityID { get; set; }

        [Key]
        [Required]
        [Column("PhoneNumber", Order = 1, TypeName = "nvarchar")]
        [StringLength(25)]
        public string PhoneNumber { get; set; }

        [Key]
        [Column("PhoneNumberTypeID", Order = 2, TypeName = "int")]
        public int PhoneNumberTypeID { get; set; }

        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Person Person { get; set; }

        public virtual PhoneNumberType PhoneNumberType { get; set; }

    }
}
