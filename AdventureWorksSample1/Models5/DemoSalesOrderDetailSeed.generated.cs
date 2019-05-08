using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Demo.DemoSalesOrderDetailSeed")]
    public partial class DemoSalesOrderDetailSeed
    {
        public DemoSalesOrderDetailSeed()
        {
            OrderQty = 0;
            ProductId = 0;
            SpecialOfferId = 0;
            OrderId = 0;
            LocalId = 0;

        }

        ///<summary>column:OrderQty</summary>
        [Column("OrderQty", Order = 0, TypeName = "smallint")]
        public short OrderQty { get; set; }

        ///<summary>column:ProductID</summary>
        [Column("ProductID", Order = 1, TypeName = "int")]
        public int ProductId { get; set; }

        ///<summary>column:SpecialOfferID</summary>
        [Column("SpecialOfferID", Order = 2, TypeName = "int")]
        public int SpecialOfferId { get; set; }

        ///<summary>column:OrderID</summary>
        [Column("OrderID", Order = 3, TypeName = "int")]
        public int OrderId { get; set; }

        ///<summary>column:LocalID</summary>
        [Key]
        [Column("LocalID", Order = 4, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocalId { get; set; }

    }
}
