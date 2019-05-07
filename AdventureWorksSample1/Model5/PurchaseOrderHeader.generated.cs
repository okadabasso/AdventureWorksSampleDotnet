using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Purchasing.PurchaseOrderHeader")]
    public partial class PurchaseOrderHeader
    {
        public PurchaseOrderHeader()
        {
            PurchaseOrderID = 0;
            RevisionNumber = 0;
            Status = 0;
            EmployeeID = 0;
            VendorID = 0;
            ShipMethodID = 0;
            OrderDate = DateTime.Parse("0001/01/01 0:00:00");
            ShipDate = null;
            SubTotal = 0;
            TaxAmt = 0;
            Freight = 0;
            TotalDue = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();

        }

        [Key]
        [Column("PurchaseOrderID", Order = 0, TypeName = "int")]
        public int PurchaseOrderID { get; set; }

        [Column("RevisionNumber", Order = 1, TypeName = "tinyint")]
        public byte RevisionNumber { get; set; }

        [Column("Status", Order = 2, TypeName = "tinyint")]
        public byte Status { get; set; }

        public int EmployeeID { get; set; }

        public int VendorID { get; set; }

        public int ShipMethodID { get; set; }

        [Column("OrderDate", Order = 6, TypeName = "datetime")]
        public DateTime OrderDate { get; set; }

        [Column("ShipDate", Order = 7, TypeName = "datetime")]
        public DateTime? ShipDate { get; set; }

        [Column("SubTotal", Order = 8, TypeName = "money")]
        public decimal SubTotal { get; set; }

        [Column("TaxAmt", Order = 9, TypeName = "money")]
        public decimal TaxAmt { get; set; }

        [Column("Freight", Order = 10, TypeName = "money")]
        public decimal Freight { get; set; }

        [Column("TotalDue", Order = 11, TypeName = "money")]
        public decimal TotalDue { get; set; }

        [Column("ModifiedDate", Order = 12, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//PurchaseOrderDetail PurchaseOrderHeader
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ShipMethod ShipMethod { get; set; }

        public virtual Vendor Vendor { get; set; }

    }
}
