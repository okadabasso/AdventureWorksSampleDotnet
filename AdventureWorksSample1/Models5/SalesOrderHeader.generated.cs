using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Sales.SalesOrderHeader")]
    public partial class SalesOrderHeader
    {
        public SalesOrderHeader()
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
            BillToAddressId = 0;
            ShipToAddressId = 0;
            ShipMethodId = 0;
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
            SalesOrderDetails = new HashSet<SalesOrderDetail>();
            SalesOrderHeaderSalesReasons = new HashSet<SalesOrderHeaderSalesReason>();

        }

        ///<summary>Primary key.</summary>
        [Key]
        [Column("SalesOrderID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesOrderId { get; set; }

        ///<summary>Incremental number to track changes to the sales order over time.</summary>
        [Column("RevisionNumber", Order = 1, TypeName = "tinyint")]
        public byte RevisionNumber { get; set; }

        ///<summary>Dates the sales order was created.</summary>
        [Column("OrderDate", Order = 2, TypeName = "datetime")]
        public DateTime OrderDate { get; set; }

        ///<summary>Date the order is due to the customer.</summary>
        [Column("DueDate", Order = 3, TypeName = "datetime")]
        public DateTime DueDate { get; set; }

        ///<summary>Date the order was shipped to the customer.</summary>
        [Column("ShipDate", Order = 4, TypeName = "datetime")]
        public DateTime? ShipDate { get; set; }

        ///<summary>Order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled</summary>
        [Column("Status", Order = 5, TypeName = "tinyint")]
        public byte Status { get; set; }

        ///<summary>0 = Order placed by sales person. 1 = Order placed online by customer.</summary>
        [Column("OnlineOrderFlag", Order = 6, TypeName = "bit")]
        public bool OnlineOrderFlag { get; set; }

        ///<summary>Unique sales order identification number.</summary>
        [Required]
        [Column("SalesOrderNumber", Order = 7, TypeName = "nvarchar")]
        [StringLength(25)]
        public string SalesOrderNumber { get; set; }

        ///<summary>Customer purchase order number reference. </summary>
        [Column("PurchaseOrderNumber", Order = 8, TypeName = "nvarchar")]
        [StringLength(25)]
        public string PurchaseOrderNumber { get; set; }

        ///<summary>Financial accounting number reference.</summary>
        [Column("AccountNumber", Order = 9, TypeName = "nvarchar")]
        [StringLength(15)]
        public string AccountNumber { get; set; }

        ///<summary>Customer identification number. Foreign key to Customer.BusinessEntityID.</summary>
        [Column("CustomerID")]
        public int CustomerId { get; set; }

        ///<summary>Sales person who created the sales order. Foreign key to SalesPerson.BusinessEntityID.</summary>
        [Column("SalesPersonID")]
        public int? SalesPersonId { get; set; }

        ///<summary>Territory in which the sale was made. Foreign key to SalesTerritory.SalesTerritoryID.</summary>
        [Column("TerritoryID")]
        public int? TerritoryId { get; set; }

        ///<summary>Customer billing address. Foreign key to Address.AddressID.</summary>
        [Column("BillToAddressID")]
        public int BillToAddressId { get; set; }

        ///<summary>Customer shipping address. Foreign key to Address.AddressID.</summary>
        [Column("ShipToAddressID")]
        public int ShipToAddressId { get; set; }

        ///<summary>Shipping method. Foreign key to ShipMethod.ShipMethodID.</summary>
        [Column("ShipMethodID")]
        public int ShipMethodId { get; set; }

        ///<summary>Credit card identification number. Foreign key to CreditCard.CreditCardID.</summary>
        [Column("CreditCardID")]
        public int? CreditCardId { get; set; }

        ///<summary>Approval code provided by the credit card company.</summary>
        [Column("CreditCardApprovalCode", Order = 17, TypeName = "varchar")]
        [StringLength(15)]
        public string CreditCardApprovalCode { get; set; }

        ///<summary>Currency exchange rate used. Foreign key to CurrencyRate.CurrencyRateID.</summary>
        [Column("CurrencyRateID")]
        public int? CurrencyRateId { get; set; }

        ///<summary>Sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID.</summary>
        [Column("SubTotal", Order = 19, TypeName = "money")]
        public decimal SubTotal { get; set; }

        ///<summary>Tax amount.</summary>
        [Column("TaxAmt", Order = 20, TypeName = "money")]
        public decimal TaxAmt { get; set; }

        ///<summary>Shipping cost.</summary>
        [Column("Freight", Order = 21, TypeName = "money")]
        public decimal Freight { get; set; }

        ///<summary>Total due from customer. Computed as Subtotal + TaxAmt + Freight.</summary>
        [Column("TotalDue", Order = 22, TypeName = "money")]
        public decimal TotalDue { get; set; }

        ///<summary>Sales representative comments.</summary>
        [Column("Comment", Order = 23, TypeName = "nvarchar")]
        [StringLength(128)]
        public string Comment { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 24, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 25, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }


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
