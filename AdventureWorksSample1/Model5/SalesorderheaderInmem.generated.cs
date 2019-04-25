using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.SalesOrderHeader_inmem")]
    public partial class SalesorderheaderInmem
    {
        [Key]
        [Column("SalesOrderID", Order = 1, TypeName = "int")]
        public int SalesOrderId { get; set; }
        [Column("RevisionNumber", Order = 2, TypeName = "tinyint")]
        public byte RevisionNumber { get; set; }
        [Column("OrderDate", Order = 3, TypeName = "datetime2")]
        public DateTime OrderDate { get; set; }
        [Column("DueDate", Order = 4, TypeName = "datetime2")]
        public DateTime DueDate { get; set; }
        [Column("ShipDate", Order = 5, TypeName = "datetime2")]
        public DateTime? ShipDate { get; set; }
        [Column("Status", Order = 6, TypeName = "tinyint")]
        public byte Status { get; set; }
        [Column("OnlineOrderFlag", Order = 7, TypeName = "bit")]
        public bool OnlineOrderFlag { get; set; }
        [Column("PurchaseOrderNumber", Order = 8, TypeName = "nvarchar")]
        [StringLength(25)]
        public string PurchaseOrderNumber { get; set; }
        [Column("AccountNumber", Order = 9, TypeName = "nvarchar")]
        [StringLength(15)]
        public string AccountNumber { get; set; }
        [Column("CustomerID", Order = 10, TypeName = "int")]
        public int CustomerId { get; set; }
        [Column("SalesPersonID", Order = 11, TypeName = "int")]
        public int SalesPersonId { get; set; }
        [Column("TerritoryID", Order = 12, TypeName = "int")]
        public int? TerritoryId { get; set; }
        [Column("BillToAddressID", Order = 13, TypeName = "int")]
        public int BillToAddressId { get; set; }
        [Column("ShipToAddressID", Order = 14, TypeName = "int")]
        public int ShipToAddressId { get; set; }
        [Column("ShipMethodID", Order = 15, TypeName = "int")]
        public int ShipMethodId { get; set; }
        [Column("CreditCardID", Order = 16, TypeName = "int")]
        public int? CreditCardId { get; set; }
        [Column("CreditCardApprovalCode", Order = 17, TypeName = "varchar")]
        [StringLength(15)]
        public string CreditCardApprovalCode { get; set; }
        [Column("CurrencyRateID", Order = 18, TypeName = "int")]
        public int? CurrencyRateId { get; set; }
        [Column("SubTotal", Order = 19, TypeName = "money")]
        public decimal SubTotal { get; set; }
        [Column("TaxAmt", Order = 20, TypeName = "money")]
        public decimal TaxAmt { get; set; }
        [Column("Freight", Order = 21, TypeName = "money")]
        public decimal Freight { get; set; }
        [Column("Comment", Order = 22, TypeName = "nvarchar")]
        [StringLength(128)]
        public string Comment { get; set; }
        [Column("ModifiedDate", Order = 23, TypeName = "datetime2")]
        public DateTime ModifiedDate { get; set; }
        public SalesorderheaderInmem()
        {
            SalesOrderId = 0;
            RevisionNumber = 0;
            OrderDate = DateTime.Parse("0001/01/01 0:00:00");
            DueDate = DateTime.Parse("0001/01/01 0:00:00");
            ShipDate = null;
            Status = 0;
            OnlineOrderFlag = false;
            PurchaseOrderNumber = null;
            AccountNumber = null;
            CustomerId = 0;
            SalesPersonId = 0;
            TerritoryId = null;
            BillToAddressId = 0;
            ShipToAddressId = 0;
            ShipMethodId = 0;
            CreditCardId = null;
            CreditCardApprovalCode = null;
            CurrencyRateId = null;
            SubTotal = 0;
            TaxAmt = 0;
            Freight = 0;
            Comment = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
