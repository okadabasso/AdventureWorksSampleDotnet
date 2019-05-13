using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("EmailAddress", Schema="Person")]
    public partial class EmailAddress
    {
        public EmailAddress()
        {

        }

        ///<summary>Primary key. Person associated with this email address.  Foreign key to Person.BusinessEntityID</summary>
        ///<remarks></remarks>
        [Key]
        [Column("BusinessEntityID", Order = 0)]
        public int BusinessEntityId { get; set; }

        ///<summary>Primary key. ID of this email address.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("EmailAddressID", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmailAddressId { get; set; }

        ///<summary>E-mail address for the person.</summary>
        ///<remarks></remarks>
        [Column("EmailAddress", Order = 2)]
        [StringLength(50)]
        public string EmailAddress1 { get; set; }

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
