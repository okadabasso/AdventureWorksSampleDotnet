namespace AdventureWorksSample1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Demo.DemoSalesOrderHeaderSeed")]
    public partial class DemoSalesOrderHeaderSeed
    {
        [Column(TypeName = "datetime2")]
        public DateTime DueDate { get; set; }

        public int CustomerID { get; set; }

        public int SalesPersonID { get; set; }

        public int BillToAddressID { get; set; }

        public int ShipToAddressID { get; set; }

        public int ShipMethodID { get; set; }

        [Key]
        public int LocalID { get; set; }
    }
}
