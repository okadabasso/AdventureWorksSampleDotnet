using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("BusinessEntityAddress", Schema="Person")]
    public partial class BusinessEntityAddress
    {
        public BusinessEntityAddress()
        {

        }

        ///<summary>Primary key. Foreign key to BusinessEntity.BusinessEntityID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("BusinessEntityID", Order = 0)]
        public int BusinessEntityId { get; set; }

        ///<summary>Primary key. Foreign key to Address.AddressID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("AddressID", Order = 1)]
        public int AddressId { get; set; }

        ///<summary>Primary key. Foreign key to AddressType.AddressTypeID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("AddressTypeID", Order = 2)]
        public int AddressTypeId { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 3)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 4)]
        public DateTime ModifiedDate { get; set; }

        public virtual Address Address { get; set; }

        public virtual AddressType AddressType { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }

    }
}
