using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("Vendor", Schema="Purchasing")]
    public partial class Vendor
    {
        public Vendor()
        {
            ProductVendors = new HashSet<ProductVendor>();
            PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();

        }

        ///<summary>Primary key for Vendor records.  Foreign key to BusinessEntity.BusinessEntityID</summary>
        ///<remarks></remarks>
        [Key]
        [Column("BusinessEntityID", Order = 0)]
        public int BusinessEntityId { get; set; }

        ///<summary>Vendor account (identification) number.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("AccountNumber", Order = 1)]
        [StringLength(15)]
        public string AccountNumber { get; set; }

        ///<summary>Company name.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Name", Order = 2)]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average</summary>
        ///<remarks></remarks>
        [Column("CreditRating", Order = 3)]
        public byte CreditRating { get; set; }

        ///<summary>0 = Do not use if another vendor is available. 1 = Preferred over other vendors supplying the same product.</summary>
        ///<remarks></remarks>
        [Column("PreferredVendorStatus", Order = 4)]
        public bool PreferredVendorStatus { get; set; }

        ///<summary>0 = Vendor no longer used. 1 = Vendor is actively used.</summary>
        ///<remarks></remarks>
        [Column("ActiveFlag", Order = 5)]
        public bool ActiveFlag { get; set; }

        ///<summary>Vendor URL.</summary>
        ///<remarks></remarks>
        [Column("PurchasingWebServiceURL", Order = 6)]
        [StringLength(1024)]
        public string PurchasingWebServiceUrl { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 7)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }

    }
}
