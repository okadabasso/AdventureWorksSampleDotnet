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
        public DemoSalesOrderHeaderSeed()
        {
            DueDate = DateTime.Parse("0001/01/01 0:00:00");
            CustomerID = 0;
            SalesPersonID = 0;
            BillToAddressID = 0;
            ShipToAddressID = 0;
            ShipMethodID = 0;
            LocalID = 0;


        }

        [Column("DueDate", Order = 0, TypeName = "datetime2")]
        public DateTime DueDate { get; set; }

        [Column("CustomerID", Order = 1, TypeName = "int")]
        public int CustomerID { get; set; }

        [Column("SalesPersonID", Order = 2, TypeName = "int")]
        public int SalesPersonID { get; set; }

        [Column("BillToAddressID", Order = 3, TypeName = "int")]
        public int BillToAddressID { get; set; }

        [Column("ShipToAddressID", Order = 4, TypeName = "int")]
        public int ShipToAddressID { get; set; }

        [Column("ShipMethodID", Order = 5, TypeName = "int")]
        public int ShipMethodID { get; set; }

        [Key]
        [Column("LocalID", Order = 6, TypeName = "int")]
        public int LocalID { get; set; }

    }
}
