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
            BusinessEntityId = 0;
            EmailAddressId = 0;
            EmailAddress1 = null;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Primary key. Person associated with this email address.  Foreign key to Person.BusinessEntityID</summary>
        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityId { get; set; }

        ///<summary>Primary key. ID of this email address.</summary>
        [Key]
        [Column("EmailAddressID", Order = 1, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmailAddressId { get; set; }

        ///<summary>E-mail address for the person.</summary>
        [Column("EmailAddress", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string EmailAddress1 { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 3, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Person Person { get; set; }

    }
}
