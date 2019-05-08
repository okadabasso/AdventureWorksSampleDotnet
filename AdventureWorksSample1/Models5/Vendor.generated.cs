using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Purchasing.Vendor")]
    public partial class Vendor
    {
        public Vendor()
        {
            BusinessEntityId = 0;
            AccountNumber = null;
            Name = null;
            CreditRating = 0;
            PreferredVendorStatus = false;
            ActiveFlag = false;
            PurchasingWebServiceUrl = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            ProductVendors = new HashSet<ProductVendor>();
            PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();

        }

        ///<summary>Primary key for Vendor records.  Foreign key to BusinessEntity.BusinessEntityID</summary>
        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityId { get; set; }

        ///<summary>Vendor account (identification) number.</summary>
        [Required]
        [Column("AccountNumber", Order = 1, TypeName = "nvarchar")]
        [StringLength(15)]
        public string AccountNumber { get; set; }

        ///<summary>Company name.</summary>
        [Required]
        [Column("Name", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average</summary>
        [Column("CreditRating", Order = 3, TypeName = "tinyint")]
        public byte CreditRating { get; set; }

        ///<summary>0 = Do not use if another vendor is available. 1 = Preferred over other vendors supplying the same product.</summary>
        [Column("PreferredVendorStatus", Order = 4, TypeName = "bit")]
        public bool PreferredVendorStatus { get; set; }

        ///<summary>0 = Vendor no longer used. 1 = Vendor is actively used.</summary>
        [Column("ActiveFlag", Order = 5, TypeName = "bit")]
        public bool ActiveFlag { get; set; }

        ///<summary>Vendor URL.</summary>
        [Column("PurchasingWebServiceURL", Order = 6, TypeName = "nvarchar")]
        [StringLength(1024)]
        public string PurchasingWebServiceUrl { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 7, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }

    }
}
