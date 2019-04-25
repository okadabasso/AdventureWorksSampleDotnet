using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Person.EmailAddress")]
    public partial class EmailAddress
    {
        [Key]
        [Column("BusinessEntityID", Order = 1, TypeName = "int")]
        public int BusinessEntityId { get; set; }
        [Key]
        [Column("EmailAddressID", Order = 2, TypeName = "int")]
        public int EmailAddressId { get; set; }
        [Column("EmailAddress", Order = 3, TypeName = "nvarchar")]
        [StringLength(50)]
        public string EmailAddress1 { get; set; }
        [Column("rowguid", Order = 4, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }
        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public EmailAddress()
        {
            BusinessEntityId = 0;
            EmailAddressId = 0;
            EmailAddress1 = null;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
