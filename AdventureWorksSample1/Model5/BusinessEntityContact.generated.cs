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
        public BusinessEntityContact()
        {
            BusinessEntityID = 0;
            PersonID = 0;
            ContactTypeID = 0;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityID { get; set; }

        [Key]
        [Column("PersonID", Order = 1, TypeName = "int")]
        public int PersonID { get; set; }

        [Key]
        [Column("ContactTypeID", Order = 2, TypeName = "int")]
        public int ContactTypeID { get; set; }

        [Column("rowguid", Order = 3, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }

        public virtual ContactType ContactType { get; set; }

        public virtual Person Person { get; set; }

    }
}
