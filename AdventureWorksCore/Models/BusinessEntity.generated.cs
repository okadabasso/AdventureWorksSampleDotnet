using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("BusinessEntity", Schema="Person")]
    public partial class BusinessEntity
    {
        public BusinessEntity()
        {
            BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();
            BusinessEntityContacts = new HashSet<BusinessEntityContact>();

        }

        ///<summary>Primary key for all customers, vendors, and employees.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("BusinessEntityID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusinessEntityId { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 1)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 2)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }

        public virtual Person Person { get; set; }

        public virtual Store Store { get; set; }

        public virtual Vendor Vendor { get; set; }

    }
}
