using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("SalesOrderHeader_inmem", Schema="Sales")]
    public partial class SalesOrderHeaderInmem
    {
        public SalesOrderHeaderInmem()
        {
            SalesOrderDetailInmems = new HashSet<SalesOrderDetailInmem>();

        }

        ///<summary>column:SalesOrderID</summary>
        ///<remarks></remarks>
        [Key]
        [Column("SalesOrderID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

        ///<summary>column:PurchaseOrderNumber</summary>
        ///<remarks></remarks>
        [Column("PurchaseOrderNumber", Order = 7)]
        [StringLength(25)]
        public string PurchaseOrderNumber { get; set; }

        ///<summary>column:AccountNumber</summary>
        ///<remarks></remarks>
        [Column("AccountNumber", Order = 8)]
        [StringLength(15)]
        public string AccountNumber { get; set; }

        ///<summary>column:CustomerID</summary>
        ///<remarks></remarks>
        [Column("CustomerID", Order = 9)]
        public int CustomerId { get; set; }

        ///<summary>column:SalesPersonID</summary>
        ///<remarks></remarks>
        [Column("SalesPersonID", Order = 10)]
        public int SalesPersonId { get; set; }

        ///<summary>column:TerritoryID</summary>
        ///<remarks></remarks>
        [Column("TerritoryID", Order = 11)]
        public int? TerritoryId { get; set; }

        ///<summary>column:BillToAddressID</summary>
        ///<remarks></remarks>
        [Column("BillToAddressID", Order = 12)]
        public int BillToAddressId { get; set; }

        ///<summary>column:ShipToAddressID</summary>
        ///<remarks></remarks>
        [Column("ShipToAddressID", Order = 13)]
        public int ShipToAddressId { get; set; }

        ///<summary>column:ShipMethodID</summary>
        ///<remarks></remarks>
        [Column("ShipMethodID", Order = 14)]
        public int ShipMethodId { get; set; }

        ///<summary>column:CreditCardID</summary>
        ///<remarks></remarks>
        [Column("CreditCardID", Order = 15)]
        public int? CreditCardId { get; set; }

        ///<summary>column:CreditCardApprovalCode</summary>
        ///<remarks></remarks>
        [Column("CreditCardApprovalCode", Order = 16)]
        [StringLength(15)]
        public string CreditCardApprovalCode { get; set; }

        ///<summary>column:CurrencyRateID</summary>
        ///<remarks></remarks>
        [Column("CurrencyRateID", Order = 17)]
        public int? CurrencyRateId { get; set; }

        ///<summary>column:SubTotal</summary>
        ///<remarks></remarks>
        [Column("SubTotal", Order = 18)]
        public decimal SubTotal { get; set; }

        ///<summary>column:TaxAmt</summary>
        ///<remarks></remarks>
        [Column("TaxAmt", Order = 19)]
        public decimal TaxAmt { get; set; }

        ///<summary>column:Freight</summary>
        ///<remarks></remarks>
        [Column("Freight", Order = 20)]
        public decimal Freight { get; set; }

        ///<summary>column:Comment</summary>
        ///<remarks></remarks>
        [Column("Comment", Order = 21)]
        [StringLength(128)]
        public string Comment { get; set; }

        ///<summary>column:ModifiedDate</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 22)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetailInmem> SalesOrderDetailInmems { get; set; }

    }
}
