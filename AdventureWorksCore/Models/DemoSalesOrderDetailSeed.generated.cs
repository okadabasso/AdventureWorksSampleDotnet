using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("DemoSalesOrderDetailSeed", Schema="Demo")]
    public partial class DemoSalesOrderDetailSeed
    {
        public DemoSalesOrderDetailSeed()
        {

        }

        ///<summary>column:OrderQty</summary>
        ///<remarks></remarks>
        [Column("OrderQty", Order = 0)]
        public short OrderQty { get; set; }

        ///<summary>column:ProductID</summary>
        ///<remarks></remarks>
        [Column("ProductID", Order = 1)]
        public int ProductId { get; set; }

        ///<summary>column:SpecialOfferID</summary>
        ///<remarks></remarks>
        [Column("SpecialOfferID", Order = 2)]
        public int SpecialOfferId { get; set; }

        ///<summary>column:OrderID</summary>
        ///<remarks></remarks>
        [Column("OrderID", Order = 3)]
        public int OrderId { get; set; }

        ///<summary>column:LocalID</summary>
        ///<remarks></remarks>
        [Key]
        [Column("LocalID", Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocalId { get; set; }

    }
}
