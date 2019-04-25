using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Demo.DemoSalesOrderHeaderSeed")]
    public partial class DemoSalesOrderHeaderSeed
    {
        [Column("DueDate", Order = 1, TypeName = "datetime2")]
        public DateTime DueDate { get; set; }
        [Column("CustomerID", Order = 2, TypeName = "int")]
        public int CustomerId { get; set; }
        [Column("SalesPersonID", Order = 3, TypeName = "int")]
        public int SalesPersonId { get; set; }
        [Column("BillToAddressID", Order = 4, TypeName = "int")]
        public int BillToAddressId { get; set; }
        [Column("ShipToAddressID", Order = 5, TypeName = "int")]
        public int ShipToAddressId { get; set; }
        [Column("ShipMethodID", Order = 6, TypeName = "int")]
        public int ShipMethodId { get; set; }
        [Key]
        [Column("LocalID", Order = 7, TypeName = "int")]
        public int LocalId { get; set; }
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
    }
}
