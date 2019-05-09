using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Sales.SalesOrder_json")]
    public partial class SalesOrderJson
    {
        public SalesOrderJson()
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

        ///<summary>column:SalesOrderID</summary>
        [Key]
        [Column("SalesOrderID", Order = 0, TypeName = "int")]
        public int SalesOrderId { get; set; }

        ///<summary>column:RevisionNumber</summary>
        [Column("RevisionNumber", Order = 1, TypeName = "tinyint")]
        public byte RevisionNumber { get; set; }

        ///<summary>column:OrderDate</summary>
        [Column("OrderDate", Order = 2, TypeName = "datetime")]
        public DateTime OrderDate { get; set; }

        ///<summary>column:DueDate</summary>
        [Column("DueDate", Order = 3, TypeName = "datetime")]
        public DateTime DueDate { get; set; }

        ///<summary>column:ShipDate</summary>
        [Column("ShipDate", Order = 4, TypeName = "datetime")]
        public DateTime? ShipDate { get; set; }

        ///<summary>column:Status</summary>
        [Column("Status", Order = 5, TypeName = "tinyint")]
        public byte Status { get; set; }

        ///<summary>column:OnlineOrderFlag</summary>
        [Column("OnlineOrderFlag", Order = 6, TypeName = "bit")]
        public bool OnlineOrderFlag { get; set; }

        ///<summary>column:SalesOrderNumber</summary>
        [Required]
        [Column("SalesOrderNumber", Order = 7, TypeName = "nvarchar")]
        [StringLength(25)]
        public string SalesOrderNumber { get; set; }

        ///<summary>column:PurchaseOrderNumber</summary>
        [Column("PurchaseOrderNumber", Order = 8, TypeName = "nvarchar")]
        [StringLength(25)]
        public string PurchaseOrderNumber { get; set; }

        ///<summary>column:AccountNumber</summary>
        [Column("AccountNumber", Order = 9, TypeName = "nvarchar")]
        [StringLength(15)]
        public string AccountNumber { get; set; }

        ///<summary>column:CustomerID</summary>
        [Column("CustomerID", Order = 10, TypeName = "int")]
        public int CustomerId { get; set; }

        ///<summary>column:SalesPersonID</summary>
        [Column("SalesPersonID", Order = 11, TypeName = "int")]
        public int? SalesPersonId { get; set; }

        ///<summary>column:TerritoryID</summary>
        [Column("TerritoryID", Order = 12, TypeName = "int")]
        public int? TerritoryId { get; set; }

        ///<summary>column:BillToAddressID</summary>
        [Column("BillToAddressID", Order = 13, TypeName = "int")]
        public int? BillToAddressId { get; set; }

        ///<summary>column:ShipToAddressID</summary>
        [Column("ShipToAddressID", Order = 14, TypeName = "int")]
        public int? ShipToAddressId { get; set; }

        ///<summary>column:ShipMethodID</summary>
        [Column("ShipMethodID", Order = 15, TypeName = "int")]
        public int? ShipMethodId { get; set; }

        ///<summary>column:CreditCardID</summary>
        [Column("CreditCardID", Order = 16, TypeName = "int")]
        public int? CreditCardId { get; set; }

        ///<summary>column:CreditCardApprovalCode</summary>
        [Column("CreditCardApprovalCode", Order = 17, TypeName = "varchar")]
        [StringLength(15)]
        public string CreditCardApprovalCode { get; set; }

        ///<summary>column:CurrencyRateID</summary>
        [Column("CurrencyRateID", Order = 18, TypeName = "int")]
        public int? CurrencyRateId { get; set; }

        ///<summary>column:SubTotal</summary>
        [Column("SubTotal", Order = 19, TypeName = "money")]
        public decimal SubTotal { get; set; }

        ///<summary>column:TaxAmt</summary>
        [Column("TaxAmt", Order = 20, TypeName = "money")]
        public decimal TaxAmt { get; set; }

        ///<summary>column:Freight</summary>
        [Column("Freight", Order = 21, TypeName = "money")]
        public decimal Freight { get; set; }

        ///<summary>column:TotalDue</summary>
        [Column("TotalDue", Order = 22, TypeName = "money")]
        public decimal TotalDue { get; set; }

        ///<summary>column:Comment</summary>
        [Column("Comment", Order = 23, TypeName = "nvarchar")]
        [StringLength(128)]
        public string Comment { get; set; }

        ///<summary>column:rowguid</summary>
        [Column("rowguid", Order = 24, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>column:ModifiedDate</summary>
        [Column("ModifiedDate", Order = 25, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

    }
}
