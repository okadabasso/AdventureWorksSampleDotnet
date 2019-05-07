using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Demo.DemoSalesOrderDetailSeed")]
    public partial class DemoSalesOrderDetailSeed
    {
        public DemoSalesOrderDetailSeed()
        {
            OrderQty = 0;
            ProductID = 0;
            SpecialOfferID = 0;
            OrderID = 0;
            LocalID = 0;


        }

        [Column("OrderQty", Order = 0, TypeName = "smallint")]
        public short OrderQty { get; set; }

        [Column("ProductID", Order = 1, TypeName = "int")]
        public int ProductID { get; set; }

        [Column("SpecialOfferID", Order = 2, TypeName = "int")]
        public int SpecialOfferID { get; set; }

        [Column("OrderID", Order = 3, TypeName = "int")]
        public int OrderID { get; set; }

        [Key]
        [Column("LocalID", Order = 4, TypeName = "int")]
        public int LocalID { get; set; }

    }
}
