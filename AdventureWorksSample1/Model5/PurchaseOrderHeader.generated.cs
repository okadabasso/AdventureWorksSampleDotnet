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
            PurchaseOrderId = 0;
            RevisionNumber = 0;
            Status = 0;
            EmployeeId = 0;
            VendorId = 0;
            ShipMethodId = 0;
            OrderDate = DateTime.Parse("0001/01/01 0:00:00");
            ShipDate = null;
            SubTotal = 0;
            TaxAmt = 0;
            Freight = 0;
            TotalDue = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();

        }

        ///<summary>Primary key.</summary>
        [Key]
        [Column("PurchaseOrderID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PurchaseOrderId { get; set; }

        ///<summary>Incremental number to track changes to the purchase order over time.</summary>
        [Column("RevisionNumber", Order = 1, TypeName = "tinyint")]
        public byte RevisionNumber { get; set; }

        ///<summary>Order current status. 1 = Pending; 2 = Approved; 3 = Rejected; 4 = Complete</summary>
        [Column("Status", Order = 2, TypeName = "tinyint")]
        public byte Status { get; set; }

        ///<summary>Employee who created the purchase order. Foreign key to Employee.BusinessEntityID.</summary>
        public int EmployeeId { get; set; }

        ///<summary>Vendor with whom the purchase order is placed. Foreign key to Vendor.BusinessEntityID.</summary>
        public int VendorId { get; set; }

        ///<summary>Shipping method. Foreign key to ShipMethod.ShipMethodID.</summary>
        public int ShipMethodId { get; set; }

        ///<summary>Purchase order creation date.</summary>
        [Column("OrderDate", Order = 6, TypeName = "datetime")]
        public DateTime OrderDate { get; set; }

        ///<summary>Estimated shipment date from the vendor.</summary>
        [Column("ShipDate", Order = 7, TypeName = "datetime")]
        public DateTime? ShipDate { get; set; }

        ///<summary>Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.</summary>
        [Column("SubTotal", Order = 8, TypeName = "money")]
        public decimal SubTotal { get; set; }

        ///<summary>Tax amount.</summary>
        [Column("TaxAmt", Order = 9, TypeName = "money")]
        public decimal TaxAmt { get; set; }

        ///<summary>Shipping cost.</summary>
        [Column("Freight", Order = 10, TypeName = "money")]
        public decimal Freight { get; set; }

        ///<summary>Total due to vendor. Computed as Subtotal + TaxAmt + Freight.</summary>
        [Column("TotalDue", Order = 11, TypeName = "money")]
        public decimal TotalDue { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 12, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ShipMethod ShipMethod { get; set; }

        public virtual Vendor Vendor { get; set; }

    }
}
