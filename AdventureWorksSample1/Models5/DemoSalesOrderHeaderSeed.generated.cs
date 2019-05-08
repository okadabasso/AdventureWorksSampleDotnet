using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Demo.DemoSalesOrderHeaderSeed")]
    public partial class DemoSalesOrderHeaderSeed
    {
        public DemoSalesOrderHeaderSeed()
        {
            DueDate = DateTime.Parse("0001/01/01 0:00:00");
            CustomerId = 0;
            SalesPersonId = 0;
            BillToAddressId = 0;
            ShipToAddressId = 0;
            ShipMethodId = 0;
            LocalId = 0;

        }

        ///<summary>column:DueDate</summary>
        [Column("DueDate", Order = 0, TypeName = "datetime2")]
        public DateTime DueDate { get; set; }

        ///<summary>column:CustomerID</summary>
        [Column("CustomerID", Order = 1, TypeName = "int")]
        public int CustomerId { get; set; }

        ///<summary>column:SalesPersonID</summary>
        [Column("SalesPersonID", Order = 2, TypeName = "int")]
        public int SalesPersonId { get; set; }

        ///<summary>column:BillToAddressID</summary>
        [Column("BillToAddressID", Order = 3, TypeName = "int")]
        public int BillToAddressId { get; set; }

        ///<summary>column:ShipToAddressID</summary>
        [Column("ShipToAddressID", Order = 4, TypeName = "int")]
        public int ShipToAddressId { get; set; }

        ///<summary>column:ShipMethodID</summary>
        [Column("ShipMethodID", Order = 5, TypeName = "int")]
        public int ShipMethodId { get; set; }

        ///<summary>column:LocalID</summary>
        [Key]
        [Column("LocalID", Order = 6, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocalId { get; set; }

    }
}
