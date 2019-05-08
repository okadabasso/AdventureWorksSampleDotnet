using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.SalesOrder_json")]
    public partial class SalesOrder_json
    {
        public SalesOrder_json()
        {
            SalesOrderID = 0;
            RevisionNumber = 0;
            OrderDate = DateTime.Parse("0001/01/01 0:00:00");
            DueDate = DateTime.Parse("0001/01/01 0:00:00");
            ShipDate = null;
            Status = 0;
            OnlineOrderFlag = false;
            SalesOrderNumber = null;
            PurchaseOrderNumber = null;
            AccountNumber = null;
            CustomerID = 0;
            SalesPersonID = null;
            TerritoryID = null;
            BillToAddressID = null;
            ShipToAddressID = null;
            ShipMethodID = null;
            CreditCardID = null;
            CreditCardApprovalCode = null;
            CurrencyRateID = null;
            SubTotal = 0;
            TaxAmt = 0;
            Freight = 0;
            TotalDue = 0;
            Comment = null;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        [Key]
        [Column("SalesOrderID", Order = 0, TypeName = "int")]
        public int SalesOrderID { get; set; }

        [Column("RevisionNumber", Order = 1, TypeName = "tinyint")]
        public byte RevisionNumber { get; set; }

        [Column("OrderDate", Order = 2, TypeName = "datetime")]
        public DateTime OrderDate { get; set; }

        [Column("DueDate", Order = 3, TypeName = "datetime")]
        public DateTime DueDate { get; set; }

        [Column("ShipDate", Order = 4, TypeName = "datetime")]
        public DateTime? ShipDate { get; set; }

        [Column("Status", Order = 5, TypeName = "tinyint")]
        public byte Status { get; set; }

        [Column("OnlineOrderFlag", Order = 6, TypeName = "bit")]
        public bool OnlineOrderFlag { get; set; }

        [Required]
        [Column("SalesOrderNumber", Order = 7, TypeName = "nvarchar")]
        [StringLength(25)]
        public string SalesOrderNumber { get; set; }

        [Column("PurchaseOrderNumber", Order = 8, TypeName = "nvarchar")]
        [StringLength(25)]
        public string PurchaseOrderNumber { get; set; }

        [Column("AccountNumber", Order = 9, TypeName = "nvarchar")]
        [StringLength(15)]
        public string AccountNumber { get; set; }

        [Column("CustomerID", Order = 10, TypeName = "int")]
        public int CustomerID { get; set; }

        [Column("SalesPersonID", Order = 11, TypeName = "int")]
        public int? SalesPersonID { get; set; }

        [Column("TerritoryID", Order = 12, TypeName = "int")]
        public int? TerritoryID { get; set; }

        [Column("BillToAddressID", Order = 13, TypeName = "int")]
        public int? BillToAddressID { get; set; }

        [Column("ShipToAddressID", Order = 14, TypeName = "int")]
        public int? ShipToAddressID { get; set; }

        [Column("ShipMethodID", Order = 15, TypeName = "int")]
        public int? ShipMethodID { get; set; }

        [Column("CreditCardID", Order = 16, TypeName = "int")]
        public int? CreditCardID { get; set; }

        [Column("CreditCardApprovalCode", Order = 17, TypeName = "varchar")]
        [StringLength(15)]
        public string CreditCardApprovalCode { get; set; }

        [Column("CurrencyRateID", Order = 18, TypeName = "int")]
        public int? CurrencyRateID { get; set; }

        [Column("SubTotal", Order = 19, TypeName = "money")]
        public decimal SubTotal { get; set; }

        [Column("TaxAmt", Order = 20, TypeName = "money")]
        public decimal TaxAmt { get; set; }

        [Column("Freight", Order = 21, TypeName = "money")]
        public decimal Freight { get; set; }

        [Column("TotalDue", Order = 22, TypeName = "money")]
        public decimal TotalDue { get; set; }

        [Column("Comment", Order = 23, TypeName = "nvarchar")]
        [StringLength(128)]
        public string Comment { get; set; }

        [Column("rowguid", Order = 24, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 25, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

    }
}
