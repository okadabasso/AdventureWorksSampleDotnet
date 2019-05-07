using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.SalesOrderHeader_ondisk")]
    public partial class SalesOrderHeader_ondisk
    {
        public SalesOrderHeader_ondisk()
        {
            SalesOrderID = 0;
            RevisionNumber = 0;
            OrderDate = DateTime.Parse("0001/01/01 0:00:00");
            DueDate = DateTime.Parse("0001/01/01 0:00:00");
            ShipDate = null;
            Status = 0;
            OnlineOrderFlag = false;
            PurchaseOrderNumber = null;
            AccountNumber = null;
            CustomerID = 0;
            SalesPersonID = 0;
            TerritoryID = null;
            BillToAddressID = 0;
            ShipToAddressID = 0;
            ShipMethodID = 0;
            CreditCardID = null;
            CreditCardApprovalCode = null;
            CurrencyRateID = null;
            SubTotal = 0;
            TaxAmt = 0;
            Freight = 0;
            Comment = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            SalesOrderDetail_ondisks = new HashSet<SalesOrderDetail_ondisk>();

        }

        [Key]
        [Column("SalesOrderID", Order = 0, TypeName = "int")]
        public int SalesOrderID { get; set; }

        [Column("RevisionNumber", Order = 1, TypeName = "tinyint")]
        public byte RevisionNumber { get; set; }

        [Column("OrderDate", Order = 2, TypeName = "datetime2")]
        public DateTime OrderDate { get; set; }

        [Column("DueDate", Order = 3, TypeName = "datetime2")]
        public DateTime DueDate { get; set; }

        [Column("ShipDate", Order = 4, TypeName = "datetime2")]
        public DateTime? ShipDate { get; set; }

        [Column("Status", Order = 5, TypeName = "tinyint")]
        public byte Status { get; set; }

        [Column("OnlineOrderFlag", Order = 6, TypeName = "bit")]
        public bool OnlineOrderFlag { get; set; }

        [Column("PurchaseOrderNumber", Order = 7, TypeName = "nvarchar")]
        [StringLength(25)]
        public string PurchaseOrderNumber { get; set; }

        [Column("AccountNumber", Order = 8, TypeName = "nvarchar")]
        [StringLength(15)]
        public string AccountNumber { get; set; }

        [Column("CustomerID", Order = 9, TypeName = "int")]
        public int CustomerID { get; set; }

        [Column("SalesPersonID", Order = 10, TypeName = "int")]
        public int SalesPersonID { get; set; }

        [Column("TerritoryID", Order = 11, TypeName = "int")]
        public int? TerritoryID { get; set; }

        [Column("BillToAddressID", Order = 12, TypeName = "int")]
        public int BillToAddressID { get; set; }

        [Column("ShipToAddressID", Order = 13, TypeName = "int")]
        public int ShipToAddressID { get; set; }

        [Column("ShipMethodID", Order = 14, TypeName = "int")]
        public int ShipMethodID { get; set; }

        [Column("CreditCardID", Order = 15, TypeName = "int")]
        public int? CreditCardID { get; set; }

        [Column("CreditCardApprovalCode", Order = 16, TypeName = "varchar")]
        [StringLength(15)]
        public string CreditCardApprovalCode { get; set; }

        [Column("CurrencyRateID", Order = 17, TypeName = "int")]
        public int? CurrencyRateID { get; set; }

        [Column("SubTotal", Order = 18, TypeName = "money")]
        public decimal SubTotal { get; set; }

        [Column("TaxAmt", Order = 19, TypeName = "money")]
        public decimal TaxAmt { get; set; }

        [Column("Freight", Order = 20, TypeName = "money")]
        public decimal Freight { get; set; }

        [Column("Comment", Order = 21, TypeName = "nvarchar")]
        [StringLength(128)]
        public string Comment { get; set; }

        [Column("ModifiedDate", Order = 22, TypeName = "datetime2")]
        public DateTime ModifiedDate { get; set; }

//SalesOrderDetail_ondisk SalesOrderHeader_ondisk
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetail_ondisk> SalesOrderDetail_ondisks { get; set; }

    }
}
