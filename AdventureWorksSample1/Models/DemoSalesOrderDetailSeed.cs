namespace AdventureWorksSample1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Demo.DemoSalesOrderDetailSeed")]
    public partial class DemoSalesOrderDetailSeed
    {
        public short OrderQty { get; set; }

        public int ProductID { get; set; }

        public int SpecialOfferID { get; set; }

        public int OrderID { get; set; }

        [Key]
        public int LocalID { get; set; }
    }
}
