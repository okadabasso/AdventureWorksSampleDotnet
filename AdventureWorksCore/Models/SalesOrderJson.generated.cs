using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("SalesOrder_json", Schema="Sales")]
    public partial class SalesOrderJson
    {
        public SalesOrderJson()
        {

        }

        ///<summary>column:SalesOrderID</summary>
        ///<remarks></remarks>
        [Key]
        [Column("SalesOrderID", Order = 0)]
        public int SalesOrderId { get; set; }

        ///<summary>column:RevisionNumber</summary>
        ///<remarks></remarks>
        [Column("RevisionNumber", Order = 1)]
        public byte RevisionNumber { get; set; }

        ///<summary>column:OrderDate</summary>
        ///<remarks></remarks>
        [Column("OrderDate", Order = 2)]
        public DateTime OrderDate { get; set; }

        ///<summary>column:DueDate</summary>
        ///<remarks></remarks>
        [Column("DueDate", Order = 3)]
        public DateTime DueDate { get; set; }

        ///<summary>column:ShipDate</summary>
        ///<remarks></remarks>
        [Column("ShipDate", Order = 4)]
        public DateTime? ShipDate { get; set; }

        ///<summary>column:Status</summary>
        ///<remarks></remarks>
        [Column("Status", Order = 5)]
        public byte Status { get; set; }

        ///<summary>column:OnlineOrderFlag</summary>
        ///<remarks></remarks>
        [Column("OnlineOrderFlag", Order = 6)]
        public bool OnlineOrderFlag { get; set; }

        ///<summary>column:SalesOrderNumber</summary>
        ///<remarks></remarks>
        [Required]
        [Column("SalesOrderNumber", Order = 7)]
        [StringLength(25)]
        public string SalesOrderNumber { get; set; }

        ///<summary>column:PurchaseOrderNumber</summary>
        ///<remarks></remarks>
        [Column("PurchaseOrderNumber", Order = 8)]
        [StringLength(25)]
        public string PurchaseOrderNumber { get; set; }

        ///<summary>column:AccountNumber</summary>
        ///<remarks></remarks>
        [Column("AccountNumber", Order = 9)]
        [StringLength(15)]
        public string AccountNumber { get; set; }

        ///<summary>column:CustomerID</summary>
        ///<remarks></remarks>
        [Column("CustomerID", Order = 10)]
        public int CustomerId { get; set; }

        ///<summary>column:SalesPersonID</summary>
        ///<remarks></remarks>
        [Column("SalesPersonID", Order = 11)]
        public int? SalesPersonId { get; set; }

        ///<summary>column:TerritoryID</summary>
        ///<remarks></remarks>
        [Column("TerritoryID", Order = 12)]
        public int? TerritoryId { get; set; }

        ///<summary>column:BillToAddressID</summary>
        ///<remarks></remarks>
        [Column("BillToAddressID", Order = 13)]
        public int? BillToAddressId { get; set; }

        ///<summary>column:ShipToAddressID</summary>
        ///<remarks></remarks>
        [Column("ShipToAddressID", Order = 14)]
        public int? ShipToAddressId { get; set; }

        ///<summary>column:ShipMethodID</summary>
        ///<remarks></remarks>
        [Column("ShipMethodID", Order = 15)]
        public int? ShipMethodId { get; set; }

        ///<summary>column:CreditCardID</summary>
        ///<remarks></remarks>
        [Column("CreditCardID", Order = 16)]
        public int? CreditCardId { get; set; }

        ///<summary>column:CreditCardApprovalCode</summary>
        ///<remarks></remarks>
        [Column("CreditCardApprovalCode", Order = 17)]
        [StringLength(15)]
        public string CreditCardApprovalCode { get; set; }

        ///<summary>column:CurrencyRateID</summary>
        ///<remarks></remarks>
        [Column("CurrencyRateID", Order = 18)]
        public int? CurrencyRateId { get; set; }

        ///<summary>column:SubTotal</summary>
        ///<remarks></remarks>
        [Column("SubTotal", Order = 19)]
        public decimal SubTotal { get; set; }

        ///<summary>column:TaxAmt</summary>
        ///<remarks></remarks>
        [Column("TaxAmt", Order = 20)]
        public decimal TaxAmt { get; set; }

        ///<summary>column:Freight</summary>
        ///<remarks></remarks>
        [Column("Freight", Order = 21)]
        public decimal Freight { get; set; }

        ///<summary>column:TotalDue</summary>
        ///<remarks></remarks>
        [Column("TotalDue", Order = 22)]
        public decimal TotalDue { get; set; }

        ///<summary>column:Comment</summary>
        ///<remarks></remarks>
        [Column("Comment", Order = 23)]
        [StringLength(128)]
        public string Comment { get; set; }

        ///<summary>column:rowguid</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 24)]
        public Guid Rowguid { get; set; }

        ///<summary>column:ModifiedDate</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 25)]
        public DateTime ModifiedDate { get; set; }

    }
}
