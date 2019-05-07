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
        public EmailAddress()
        {
            BusinessEntityID = 0;
            EmailAddressID = 0;
            EmailAddress1 = null;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityID { get; set; }

        [Key]
        [Column("EmailAddressID", Order = 1, TypeName = "int")]
        public int EmailAddressID { get; set; }

        [Column("EmailAddress", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string EmailAddress1 { get; set; }

        [Column("rowguid", Order = 3, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Person Person { get; set; }

    }
}
