using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Person.BusinessEntityContact")]
    public partial class BusinessEntityContact
    {
        [Key]
        [Column("BusinessEntityID", Order = 1, TypeName = "int")]
        public int BusinessEntityId { get; set; }
        [Key]
        [Column("PersonID", Order = 2, TypeName = "int")]
        public int PersonId { get; set; }
        [Key]
        [Column("ContactTypeID", Order = 3, TypeName = "int")]
        public int ContactTypeId { get; set; }
        [Column("rowguid", Order = 4, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }
        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public BusinessEntityContact()
        {
            BusinessEntityId = 0;
            PersonId = 0;
            ContactTypeId = 0;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
