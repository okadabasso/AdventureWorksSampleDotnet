using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.SalesOrderHeader")]
    public partial class SalesOrderHeader
    {
        public SalesOrderHeader()
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
            BillToAddressID = 0;
            ShipToAddressID = 0;
            ShipMethodID = 0;
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

            SalesOrderDetails = new HashSet<SalesOrderDetail>();
            SalesOrderHeaderSalesReasons = new HashSet<SalesOrderHeaderSalesReason>();

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

        public int CustomerID { get; set; }

        public int? SalesPersonID { get; set; }

        public int? TerritoryID { get; set; }

        public int BillToAddressID { get; set; }

        public int ShipToAddressID { get; set; }

        public int ShipMethodID { get; set; }

        public int? CreditCardID { get; set; }

        [Column("CreditCardApprovalCode", Order = 17, TypeName = "varchar")]
        [StringLength(15)]
        public string CreditCardApprovalCode { get; set; }

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

//SalesOrderDetail SalesOrderHeader
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }

//SalesOrderHeaderSalesReason SalesOrderHeader
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }

        public virtual Address Address { get; set; }

        public virtual Address Address1 { get; set; }

        public virtual CreditCard CreditCard { get; set; }

        public virtual CurrencyRate CurrencyRate { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual SalesPerson SalesPerson { get; set; }

        public virtual SalesTerritory SalesTerritory { get; set; }

        public virtual ShipMethod ShipMethod { get; set; }

    }
}
