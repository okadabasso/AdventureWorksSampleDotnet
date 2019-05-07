using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Person.BusinessEntityAddress")]
    public partial class BusinessEntityAddress
    {
        public BusinessEntityAddress()
        {
            BusinessEntityID = 0;
            AddressID = 0;
            AddressTypeID = 0;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityID { get; set; }

        [Key]
        [Column("AddressID", Order = 1, TypeName = "int")]
        public int AddressID { get; set; }

        [Key]
        [Column("AddressTypeID", Order = 2, TypeName = "int")]
        public int AddressTypeID { get; set; }

        [Column("rowguid", Order = 3, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Address Address { get; set; }

        public virtual AddressType AddressType { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }

    }
}
