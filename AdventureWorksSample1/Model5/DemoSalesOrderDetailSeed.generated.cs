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
        [Column("OrderQty", Order = 1, TypeName = "smallint")]
        public short OrderQty { get; set; }
        [Column("ProductID", Order = 2, TypeName = "int")]
        public int ProductId { get; set; }
        [Column("SpecialOfferID", Order = 3, TypeName = "int")]
        public int SpecialOfferId { get; set; }
        [Column("OrderID", Order = 4, TypeName = "int")]
        public int OrderId { get; set; }
        [Key]
        [Column("LocalID", Order = 5, TypeName = "int")]
        public int LocalId { get; set; }
        public DemoSalesOrderDetailSeed()
        {
            OrderQty = 0;
            ProductId = 0;
            SpecialOfferId = 0;
            OrderId = 0;
            LocalId = 0;
        }
    }
}
