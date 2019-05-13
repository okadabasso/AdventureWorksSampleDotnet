using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("SalesOrderHeader", Schema="Sales")]
    public partial class SalesOrderHeader
    {
        public SalesOrderHeader()
        {
            SalesOrderDetails = new HashSet<SalesOrderDetail>();
            SalesOrderHeaderSalesReasons = new HashSet<SalesOrderHeaderSalesReason>();

        }

        ///<summary>Primary key.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("SalesOrderID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesOrderId { get; set; }

        ///<summary>Incremental number to track changes to the sales order over time.</summary>
        ///<remarks></remarks>
        [Column("RevisionNumber", Order = 1)]
        public byte RevisionNumber { get; set; }

        ///<summary>Dates the sales order was created.</summary>
        ///<remarks></remarks>
        [Column("OrderDate", Order = 2)]
        public DateTime OrderDate { get; set; }

        ///<summary>Date the order is due to the customer.</summary>
        ///<remarks></remarks>
        [Column("DueDate", Order = 3)]
        public DateTime DueDate { get; set; }

        ///<summary>Date the order was shipped to the customer.</summary>
        ///<remarks></remarks>
        [Column("ShipDate", Order = 4)]
        public DateTime? ShipDate { get; set; }

        ///<summary>Order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled</summary>
        ///<remarks></remarks>
        [Column("Status", Order = 5)]
        public byte Status { get; set; }

        ///<summary>0 = Order placed by sales person. 1 = Order placed online by customer.</summary>
        ///<remarks></remarks>
        [Column("OnlineOrderFlag", Order = 6)]
        public bool OnlineOrderFlag { get; set; }

        ///<summary>Unique sales order identification number.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("SalesOrderNumber", Order = 7)]
        [StringLength(25)]
        public string SalesOrderNumber { get; set; }

        ///<summary>Customer purchase order number reference. </summary>
        ///<remarks></remarks>
        [Column("PurchaseOrderNumber", Order = 8)]
        [StringLength(25)]
        public string PurchaseOrderNumber { get; set; }

        ///<summary>Financial accounting number reference.</summary>
        ///<remarks></remarks>
        [Column("AccountNumber", Order = 9)]
        [StringLength(15)]
        public string AccountNumber { get; set; }

        ///<summary>Customer identification number. Foreign key to Customer.BusinessEntityID.</summary>
        ///<remarks></remarks>
        [Column("CustomerID")]
        public int CustomerId { get; set; }

        ///<summary>Sales person who created the sales order. Foreign key to SalesPerson.BusinessEntityID.</summary>
        ///<remarks></remarks>
        [Column("SalesPersonID")]
        public int? SalesPersonId { get; set; }

        ///<summary>Territory in which the sale was made. Foreign key to SalesTerritory.SalesTerritoryID.</summary>
        ///<remarks></remarks>
        [Column("TerritoryID")]
        public int? TerritoryId { get; set; }

        ///<summary>Customer billing address. Foreign key to Address.AddressID.</summary>
        ///<remarks></remarks>
        [Column("BillToAddressID")]
        public int BillToAddressId { get; set; }

        ///<summary>Customer shipping address. Foreign key to Address.AddressID.</summary>
        ///<remarks></remarks>
        [Column("ShipToAddressID")]
        public int ShipToAddressId { get; set; }

        ///<summary>Shipping method. Foreign key to ShipMethod.ShipMethodID.</summary>
        ///<remarks></remarks>
        [Column("ShipMethodID")]
        public int ShipMethodId { get; set; }

        ///<summary>Credit card identification number. Foreign key to CreditCard.CreditCardID.</summary>
        ///<remarks></remarks>
        [Column("CreditCardID")]
        public int? CreditCardId { get; set; }

        ///<summary>Approval code provided by the credit card company.</summary>
        ///<remarks></remarks>
        [Column("CreditCardApprovalCode", Order = 17)]
        [StringLength(15)]
        public string CreditCardApprovalCode { get; set; }

        ///<summary>Currency exchange rate used. Foreign key to CurrencyRate.CurrencyRateID.</summary>
        ///<remarks></remarks>
        [Column("CurrencyRateID")]
        public int? CurrencyRateId { get; set; }

        ///<summary>Sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID.</summary>
        ///<remarks></remarks>
        [Column("SubTotal", Order = 19)]
        public decimal SubTotal { get; set; }

        ///<summary>Tax amount.</summary>
        ///<remarks></remarks>
        [Column("TaxAmt", Order = 20)]
        public decimal TaxAmt { get; set; }

        ///<summary>Shipping cost.</summary>
        ///<remarks></remarks>
        [Column("Freight", Order = 21)]
        public decimal Freight { get; set; }

        ///<summary>Total due from customer. Computed as Subtotal + TaxAmt + Freight.</summary>
        ///<remarks></remarks>
        [Column("TotalDue", Order = 22)]
        public decimal TotalDue { get; set; }

        ///<summary>Sales representative comments.</summary>
        ///<remarks></remarks>
        [Column("Comment", Order = 23)]
        [StringLength(128)]
        public string Comment { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 24)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 25)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }

        public virtual Address BillToAddress { get; set; }

        public virtual Address ShipToAddress { get; set; }

        public virtual CreditCard CreditCard { get; set; }

        public virtual CurrencyRate CurrencyRate { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual SalesPerson SalesPerson { get; set; }

        public virtual SalesTerritory SalesTerritory { get; set; }

        public virtual ShipMethod ShipMethod { get; set; }

    }
}
