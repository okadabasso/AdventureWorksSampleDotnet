using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("DemoSalesOrderHeaderSeed", Schema="Demo")]
    public partial class DemoSalesOrderHeaderSeed
    {
        public DemoSalesOrderHeaderSeed()
        {

        }

        ///<summary>column:DueDate</summary>
        ///<remarks></remarks>
        [Column("DueDate", Order = 0)]
        public DateTime DueDate { get; set; }

        ///<summary>column:CustomerID</summary>
        ///<remarks></remarks>
        [Column("CustomerID", Order = 1)]
        public int CustomerId { get; set; }

        ///<summary>column:SalesPersonID</summary>
        ///<remarks></remarks>
        [Column("SalesPersonID", Order = 2)]
        public int SalesPersonId { get; set; }

        ///<summary>column:BillToAddressID</summary>
        ///<remarks></remarks>
        [Column("BillToAddressID", Order = 3)]
        public int BillToAddressId { get; set; }

        ///<summary>column:ShipToAddressID</summary>
        ///<remarks></remarks>
        [Column("ShipToAddressID", Order = 4)]
        public int ShipToAddressId { get; set; }

        ///<summary>column:ShipMethodID</summary>
        ///<remarks></remarks>
        [Column("ShipMethodID", Order = 5)]
        public int ShipMethodId { get; set; }

        ///<summary>column:LocalID</summary>
        ///<remarks></remarks>
        [Key]
        [Column("LocalID", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocalId { get; set; }

    }
}
