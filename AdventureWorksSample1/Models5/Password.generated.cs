using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Person.Password")]
    public partial class Password
    {
        public Password()
        {
            BusinessEntityId = 0;
            PasswordHash = null;
            PasswordSalt = null;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>column:BusinessEntityID</summary>
        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityId { get; set; }

        ///<summary>Password for the e-mail account.</summary>
        [Required]
        [Column("PasswordHash", Order = 1, TypeName = "varchar")]
        [StringLength(128)]
        public string PasswordHash { get; set; }

        ///<summary>Random value concatenated with the password string before the password is hashed.</summary>
        [Required]
        [Column("PasswordSalt", Order = 2, TypeName = "varchar")]
        [StringLength(10)]
        public string PasswordSalt { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 3, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Person Person { get; set; }

    }
}
