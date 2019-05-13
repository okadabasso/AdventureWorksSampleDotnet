using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("BusinessEntityContact", Schema="Person")]
    public partial class BusinessEntityContact
    {
        public BusinessEntityContact()
        {

        }

        ///<summary>Primary key. Foreign key to BusinessEntity.BusinessEntityID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("BusinessEntityID", Order = 0)]
        public int BusinessEntityId { get; set; }

        ///<summary>Primary key. Foreign key to Person.BusinessEntityID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("PersonID", Order = 1)]
        public int PersonId { get; set; }

        ///<summary>Primary key.  Foreign key to ContactType.ContactTypeID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ContactTypeID", Order = 2)]
        public int ContactTypeId { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 3)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 4)]
        public DateTime ModifiedDate { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }

        public virtual ContactType ContactType { get; set; }

        public virtual Person Person { get; set; }

    }
}
