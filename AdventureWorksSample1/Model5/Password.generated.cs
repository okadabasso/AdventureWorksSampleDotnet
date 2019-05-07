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
        public Password()
        {
            BusinessEntityID = 0;
            PasswordHash = null;
            PasswordSalt = null;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityID { get; set; }

        [Required]
        [Column("PasswordHash", Order = 1, TypeName = "varchar")]
        [StringLength(128)]
        public string PasswordHash { get; set; }

        [Required]
        [Column("PasswordSalt", Order = 2, TypeName = "varchar")]
        [StringLength(10)]
        public string PasswordSalt { get; set; }

        [Column("rowguid", Order = 3, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Person Person { get; set; }

    }
}
