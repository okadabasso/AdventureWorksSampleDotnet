using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.SalesOrder_json")]
    public partial class SalesorderJson
    {
        [Key]
        [Column("SalesOrderID", Order = 1, TypeName = "int")]
        public int SalesOrderId { get; set; }
        [Column("RevisionNumber", Order = 2, TypeName = "tinyint")]
        public byte RevisionNumber { get; set; }
        [Column("OrderDate", Order = 3, TypeName = "datetime")]
        public DateTime OrderDate { get; set; }
        [Column("DueDate", Order = 4, TypeName = "datetime")]
        public DateTime DueDate { get; set; }
        [Column("ShipDate", Order = 5, TypeName = "datetime")]
        public DateTime? ShipDate { get; set; }
        [Column("Status", Order = 6, TypeName = "tinyint")]
        public byte Status { get; set; }
        [Column("OnlineOrderFlag", Order = 7, TypeName = "bit")]
        public bool OnlineOrderFlag { get; set; }
        [Column("SalesOrderNumber", Order = 8, TypeName = "nvarchar")]
        [StringLength(25)]
        public string SalesOrderNumber { get; set; }
        [Column("PurchaseOrderNumber", Order = 9, TypeName = "nvarchar")]
        [StringLength(25)]
        public string PurchaseOrderNumber { get; set; }
        [Column("AccountNumber", Order = 10, TypeName = "nvarchar")]
        [StringLength(15)]
        public string AccountNumber { get; set; }
        [Column("CustomerID", Order = 11, TypeName = "int")]
        public int CustomerId { get; set; }
        [Column("SalesPersonID", Order = 12, TypeName = "int")]
        public int? SalesPersonId { get; set; }
        [Column("TerritoryID", Order = 13, TypeName = "int")]
        public int? TerritoryId { get; set; }
        [Column("BillToAddressID", Order = 14, TypeName = "int")]
        public int? BillToAddressId { get; set; }
        [Column("ShipToAddressID", Order = 15, TypeName = "int")]
        public int? ShipToAddressId { get; set; }
        [Column("ShipMethodID", Order = 16, TypeName = "int")]
        public int? ShipMethodId { get; set; }
        [Column("CreditCardID", Order = 17, TypeName = "int")]
        public int? CreditCardId { get; set; }
        [Column("CreditCardApprovalCode", Order = 18, TypeName = "varchar")]
        [StringLength(15)]
        public string CreditCardApprovalCode { get; set; }
        [Column("CurrencyRateID", Order = 19, TypeName = "int")]
        public int? CurrencyRateId { get; set; }
        [Column("SubTotal", Order = 20, TypeName = "money")]
        public decimal SubTotal { get; set; }
        [Column("TaxAmt", Order = 21, TypeName = "money")]
        public decimal TaxAmt { get; set; }
        [Column("Freight", Order = 22, TypeName = "money")]
        public decimal Freight { get; set; }
        [Column("TotalDue", Order = 23, TypeName = "money")]
        public decimal TotalDue { get; set; }
        [Column("Comment", Order = 24, TypeName = "nvarchar")]
        [StringLength(128)]
        public string Comment { get; set; }
        [Column("rowguid", Order = 25, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }
        [Column("ModifiedDate", Order = 26, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public SalesorderJson()
        {
            SalesOrderId = 0;
            RevisionNumber = 0;
            OrderDate = DateTime.Parse("0001/01/01 0:00:00");
            DueDate = DateTime.Parse("0001/01/01 0:00:00");
            ShipDate = null;
            Status = 0;
            OnlineOrderFlag = false;
            SalesOrderNumber = null;
            PurchaseOrderNumber = null;
            AccountNumber = null;
            CustomerId = 0;
            SalesPersonId = null;
            TerritoryId = null;
            BillToAddressId = null;
            ShipToAddressId = null;
            ShipMethodId = null;
            CreditCardId = null;
            CreditCardApprovalCode = null;
            CurrencyRateId = null;
            SubTotal = 0;
            TaxAmt = 0;
            Freight = 0;
            TotalDue = 0;
            Comment = null;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
