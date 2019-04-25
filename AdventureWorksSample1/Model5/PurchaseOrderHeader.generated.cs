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
        [Key]
        [Column("PurchaseOrderID", Order = 1, TypeName = "int")]
        public int PurchaseOrderId { get; set; }
        [Column("RevisionNumber", Order = 2, TypeName = "tinyint")]
        public byte RevisionNumber { get; set; }
        [Column("Status", Order = 3, TypeName = "tinyint")]
        public byte Status { get; set; }
        [Column("EmployeeID", Order = 4, TypeName = "int")]
        public int EmployeeId { get; set; }
        [Column("VendorID", Order = 5, TypeName = "int")]
        public int VendorId { get; set; }
        [Column("ShipMethodID", Order = 6, TypeName = "int")]
        public int ShipMethodId { get; set; }
        [Column("OrderDate", Order = 7, TypeName = "datetime")]
        public DateTime OrderDate { get; set; }
        [Column("ShipDate", Order = 8, TypeName = "datetime")]
        public DateTime? ShipDate { get; set; }
        [Column("SubTotal", Order = 9, TypeName = "money")]
        public decimal SubTotal { get; set; }
        [Column("TaxAmt", Order = 10, TypeName = "money")]
        public decimal TaxAmt { get; set; }
        [Column("Freight", Order = 11, TypeName = "money")]
        public decimal Freight { get; set; }
        [Column("TotalDue", Order = 12, TypeName = "money")]
        public decimal TotalDue { get; set; }
        [Column("ModifiedDate", Order = 13, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
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
        }
    }
}
