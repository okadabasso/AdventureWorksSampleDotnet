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
        [Key]
        [Column("BusinessEntityID", Order = 1, TypeName = "int")]
        public int BusinessEntityId { get; set; }
        [Column("AccountNumber", Order = 2, TypeName = "nvarchar")]
        [StringLength(15)]
        public string AccountNumber { get; set; }
        [Column("Name", Order = 3, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("CreditRating", Order = 4, TypeName = "tinyint")]
        public byte CreditRating { get; set; }
        [Column("PreferredVendorStatus", Order = 5, TypeName = "bit")]
        public bool PreferredVendorStatus { get; set; }
        [Column("ActiveFlag", Order = 6, TypeName = "bit")]
        public bool ActiveFlag { get; set; }
        [Column("PurchasingWebServiceURL", Order = 7, TypeName = "nvarchar")]
        [StringLength(1024)]
        public string PurchasingWebServiceUrl { get; set; }
        [Column("ModifiedDate", Order = 8, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
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
        }
    }
}
