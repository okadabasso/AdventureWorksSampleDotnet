using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Sales.SalesOrderHeader_ondisk")]
    public partial class SalesOrderHeaderOndisk
    {
        public SalesOrderHeaderOndisk()
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
            SalesOrderDetailOndisks = new HashSet<SalesOrderDetailOndisk>();

        }

        ///<summary>column:SalesOrderID</summary>
        [Key]
        [Column("SalesOrderID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesOrderId { get; set; }

        ///<summary>column:RevisionNumber</summary>
        [Column("RevisionNumber", Order = 1, TypeName = "tinyint")]
        public byte RevisionNumber { get; set; }

        ///<summary>column:OrderDate</summary>
        [Column("OrderDate", Order = 2, TypeName = "datetime2")]
        public DateTime OrderDate { get; set; }

        ///<summary>column:DueDate</summary>
        [Column("DueDate", Order = 3, TypeName = "datetime2")]
        public DateTime DueDate { get; set; }

        ///<summary>column:ShipDate</summary>
        [Column("ShipDate", Order = 4, TypeName = "datetime2")]
        public DateTime? ShipDate { get; set; }

        ///<summary>column:Status</summary>
        [Column("Status", Order = 5, TypeName = "tinyint")]
        public byte Status { get; set; }

        ///<summary>column:OnlineOrderFlag</summary>
        [Column("OnlineOrderFlag", Order = 6, TypeName = "bit")]
        public bool OnlineOrderFlag { get; set; }

        ///<summary>column:PurchaseOrderNumber</summary>
        [Column("PurchaseOrderNumber", Order = 7, TypeName = "nvarchar")]
        [StringLength(25)]
        public string PurchaseOrderNumber { get; set; }

        ///<summary>column:AccountNumber</summary>
        [Column("AccountNumber", Order = 8, TypeName = "nvarchar")]
        [StringLength(15)]
        public string AccountNumber { get; set; }

        ///<summary>column:CustomerID</summary>
        [Column("CustomerID", Order = 9, TypeName = "int")]
        public int CustomerId { get; set; }

        ///<summary>column:SalesPersonID</summary>
        [Column("SalesPersonID", Order = 10, TypeName = "int")]
        public int SalesPersonId { get; set; }

        ///<summary>column:TerritoryID</summary>
        [Column("TerritoryID", Order = 11, TypeName = "int")]
        public int? TerritoryId { get; set; }

        ///<summary>column:BillToAddressID</summary>
        [Column("BillToAddressID", Order = 12, TypeName = "int")]
        public int BillToAddressId { get; set; }

        ///<summary>column:ShipToAddressID</summary>
        [Column("ShipToAddressID", Order = 13, TypeName = "int")]
        public int ShipToAddressId { get; set; }

        ///<summary>column:ShipMethodID</summary>
        [Column("ShipMethodID", Order = 14, TypeName = "int")]
        public int ShipMethodId { get; set; }

        ///<summary>column:CreditCardID</summary>
        [Column("CreditCardID", Order = 15, TypeName = "int")]
        public int? CreditCardId { get; set; }

        ///<summary>column:CreditCardApprovalCode</summary>
        [Column("CreditCardApprovalCode", Order = 16, TypeName = "varchar")]
        [StringLength(15)]
        public string CreditCardApprovalCode { get; set; }

        ///<summary>column:CurrencyRateID</summary>
        [Column("CurrencyRateID", Order = 17, TypeName = "int")]
        public int? CurrencyRateId { get; set; }

        ///<summary>column:SubTotal</summary>
        [Column("SubTotal", Order = 18, TypeName = "money")]
        public decimal SubTotal { get; set; }

        ///<summary>column:TaxAmt</summary>
        [Column("TaxAmt", Order = 19, TypeName = "money")]
        public decimal TaxAmt { get; set; }

        ///<summary>column:Freight</summary>
        [Column("Freight", Order = 20, TypeName = "money")]
        public decimal Freight { get; set; }

        ///<summary>column:Comment</summary>
        [Column("Comment", Order = 21, TypeName = "nvarchar")]
        [StringLength(128)]
        public string Comment { get; set; }

        ///<summary>column:ModifiedDate</summary>
        [Column("ModifiedDate", Order = 22, TypeName = "datetime2")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetailOndisk> SalesOrderDetailOndisks { get; set; }

    }
}
