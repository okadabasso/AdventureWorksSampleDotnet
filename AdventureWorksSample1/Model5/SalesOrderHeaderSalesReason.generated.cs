using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.SalesOrderHeaderSalesReason")]
    public partial class SalesOrderHeaderSalesReason
    {
        [Key]
        [Column("SalesOrderID", Order = 1, TypeName = "int")]
        public int SalesOrderId { get; set; }
        [Key]
        [Column("SalesReasonID", Order = 2, TypeName = "int")]
        public int SalesReasonId { get; set; }
        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public SalesOrderHeaderSalesReason()
        {
            SalesOrderId = 0;
            SalesReasonId = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
