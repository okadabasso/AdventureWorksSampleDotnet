using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("Password", Schema="Person")]
    public partial class Password
    {
        public Password()
        {

        }

        ///<summary>column:BusinessEntityID</summary>
        ///<remarks></remarks>
        [Key]
        [Column("BusinessEntityID", Order = 0)]
        public int BusinessEntityId { get; set; }

        ///<summary>Password for the e-mail account.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("PasswordHash", Order = 1)]
        [StringLength(128)]
        public string PasswordHash { get; set; }

        ///<summary>Random value concatenated with the password string before the password is hashed.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("PasswordSalt", Order = 2)]
        [StringLength(10)]
        public string PasswordSalt { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 3)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 4)]
        public DateTime ModifiedDate { get; set; }

        public virtual Person Person { get; set; }

    }
}
