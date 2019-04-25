using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Person.Password")]
    public partial class Password
    {
        [Key]
        [Column("BusinessEntityID", Order = 1, TypeName = "int")]
        public int BusinessEntityId { get; set; }
        [Column("PasswordHash", Order = 2, TypeName = "varchar")]
        [StringLength(128)]
        public string PasswordHash { get; set; }
        [Column("PasswordSalt", Order = 3, TypeName = "varchar")]
        [StringLength(10)]
        public string PasswordSalt { get; set; }
        [Column("rowguid", Order = 4, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }
        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public Password()
        {
            BusinessEntityId = 0;
            PasswordHash = null;
            PasswordSalt = null;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
