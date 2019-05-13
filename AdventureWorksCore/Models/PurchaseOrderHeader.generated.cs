using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("PurchaseOrderHeader", Schema="Purchasing")]
    public partial class PurchaseOrderHeader
    {
        public PurchaseOrderHeader()
        {
            PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();

        }

        ///<summary>Primary key.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("PurchaseOrderID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PurchaseOrderId { get; set; }

        ///<summary>Incremental number to track changes to the purchase order over time.</summary>
        ///<remarks></remarks>
        [Column("RevisionNumber", Order = 1)]
        public byte RevisionNumber { get; set; }

        ///<summary>Order current status. 1 = Pending; 2 = Approved; 3 = Rejected; 4 = Complete</summary>
        ///<remarks></remarks>
        [Column("Status", Order = 2)]
        public byte Status { get; set; }

        ///<summary>Employee who created the purchase order. Foreign key to Employee.BusinessEntityID.</summary>
        ///<remarks></remarks>
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }

        ///<summary>Vendor with whom the purchase order is placed. Foreign key to Vendor.BusinessEntityID.</summary>
        ///<remarks></remarks>
        [Column("VendorID")]
        public int VendorId { get; set; }

        ///<summary>Shipping method. Foreign key to ShipMethod.ShipMethodID.</summary>
        ///<remarks></remarks>
        [Column("ShipMethodID")]
        public int ShipMethodId { get; set; }

        ///<summary>Purchase order creation date.</summary>
        ///<remarks></remarks>
        [Column("OrderDate", Order = 6)]
        public DateTime OrderDate { get; set; }

        ///<summary>Estimated shipment date from the vendor.</summary>
        ///<remarks></remarks>
        [Column("ShipDate", Order = 7)]
        public DateTime? ShipDate { get; set; }

        ///<summary>Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.</summary>
        ///<remarks></remarks>
        [Column("SubTotal", Order = 8)]
        public decimal SubTotal { get; set; }

        ///<summary>Tax amount.</summary>
        ///<remarks></remarks>
        [Column("TaxAmt", Order = 9)]
        public decimal TaxAmt { get; set; }

        ///<summary>Shipping cost.</summary>
        ///<remarks></remarks>
        [Column("Freight", Order = 10)]
        public decimal Freight { get; set; }

        ///<summary>Total due to vendor. Computed as Subtotal + TaxAmt + Freight.</summary>
        ///<remarks></remarks>
        [Column("TotalDue", Order = 11)]
        public decimal TotalDue { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 12)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ShipMethod ShipMethod { get; set; }

        public virtual Vendor Vendor { get; set; }

    }
}
