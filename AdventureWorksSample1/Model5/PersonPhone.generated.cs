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
        [Key]
        [Column("BusinessEntityID", Order = 1, TypeName = "int")]
        public int BusinessEntityId { get; set; }
        [Key]
        [Column("PhoneNumber", Order = 2, TypeName = "nvarchar")]
        [StringLength(25)]
        public string PhoneNumber { get; set; }
        [Key]
        [Column("PhoneNumberTypeID", Order = 3, TypeName = "int")]
        public int PhoneNumberTypeId { get; set; }
        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public PersonPhone()
        {
            BusinessEntityId = 0;
            PhoneNumber = null;
            PhoneNumberTypeId = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
