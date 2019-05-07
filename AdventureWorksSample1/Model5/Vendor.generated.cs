using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Purchasing.Vendor")]
    public partial class Vendor
    {
        public Vendor()
        {
            BusinessEntityID = 0;
            AccountNumber = null;
            Name = null;
            CreditRating = 0;
            PreferredVendorStatus = false;
            ActiveFlag = false;
            PurchasingWebServiceURL = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            ProductVendors = new HashSet<ProductVendor>();
            PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();

        }

        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityID { get; set; }

        [Required]
        [Column("AccountNumber", Order = 1, TypeName = "nvarchar")]
        [StringLength(15)]
        public string AccountNumber { get; set; }

        [Required]
        [Column("Name", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("CreditRating", Order = 3, TypeName = "tinyint")]
        public byte CreditRating { get; set; }

        [Column("PreferredVendorStatus", Order = 4, TypeName = "bit")]
        public bool PreferredVendorStatus { get; set; }

        [Column("ActiveFlag", Order = 5, TypeName = "bit")]
        public bool ActiveFlag { get; set; }

        [Column("PurchasingWebServiceURL", Order = 6, TypeName = "nvarchar")]
        [StringLength(1024)]
        public string PurchasingWebServiceURL { get; set; }

        [Column("ModifiedDate", Order = 7, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//ProductVendor Vendor
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }

//PurchaseOrderHeader Vendor
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }

    }
}
