using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Person.BusinessEntityContact")]
    public partial class BusinessEntityContact
    {
        public BusinessEntityContact()
        {
            BusinessEntityId = 0;
            PersonId = 0;
            ContactTypeId = 0;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Primary key. Foreign key to BusinessEntity.BusinessEntityID.</summary>
        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityId { get; set; }

        ///<summary>Primary key. Foreign key to Person.BusinessEntityID.</summary>
        [Key]
        [Column("PersonID", Order = 1, TypeName = "int")]
        public int PersonId { get; set; }

        ///<summary>Primary key.  Foreign key to ContactType.ContactTypeID.</summary>
        [Key]
        [Column("ContactTypeID", Order = 2, TypeName = "int")]
        public int ContactTypeId { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 3, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }

        public virtual ContactType ContactType { get; set; }

        public virtual Person Person { get; set; }

    }
}
