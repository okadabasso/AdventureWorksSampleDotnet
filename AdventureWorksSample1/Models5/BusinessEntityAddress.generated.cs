using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Person.BusinessEntityAddress")]
    public partial class BusinessEntityAddress
    {
        public BusinessEntityAddress()
        {
            BusinessEntityId = 0;
            AddressId = 0;
            AddressTypeId = 0;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Primary key. Foreign key to BusinessEntity.BusinessEntityID.</summary>
        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityId { get; set; }

        ///<summary>Primary key. Foreign key to Address.AddressID.</summary>
        [Key]
        [Column("AddressID", Order = 1, TypeName = "int")]
        public int AddressId { get; set; }

        ///<summary>Primary key. Foreign key to AddressType.AddressTypeID.</summary>
        [Key]
        [Column("AddressTypeID", Order = 2, TypeName = "int")]
        public int AddressTypeId { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 3, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Address Address { get; set; }

        public virtual AddressType AddressType { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }

    }
}
