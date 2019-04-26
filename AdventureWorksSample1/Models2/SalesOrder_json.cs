//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureWorksSample1.Models2
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesOrder_json
    {
        public int SalesOrderID { get; set; }
        public byte RevisionNumber { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public byte Status { get; set; }
        public bool OnlineOrderFlag { get; set; }
        public string SalesOrderNumber { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string AccountNumber { get; set; }
        public int CustomerID { get; set; }
        public Nullable<int> SalesPersonID { get; set; }
        public Nullable<int> TerritoryID { get; set; }
        public Nullable<int> BillToAddressID { get; set; }
        public Nullable<int> ShipToAddressID { get; set; }
        public Nullable<int> ShipMethodID { get; set; }
        public Nullable<int> CreditCardID { get; set; }
        public string CreditCardApprovalCode { get; set; }
        public Nullable<int> CurrencyRateID { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal Freight { get; set; }
        public decimal TotalDue { get; set; }
        public string Comment { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}