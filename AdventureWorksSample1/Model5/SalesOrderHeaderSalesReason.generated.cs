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
        public SalesOrderHeaderSalesReason()
        {
            SalesOrderID = 0;
            SalesReasonID = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("SalesOrderID", Order = 0, TypeName = "int")]
        public int SalesOrderID { get; set; }

        [Key]
        [Column("SalesReasonID", Order = 1, TypeName = "int")]
        public int SalesReasonID { get; set; }

        [Column("ModifiedDate", Order = 2, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual SalesOrderHeader SalesOrderHeader { get; set; }

        public virtual SalesReason SalesReason { get; set; }

    }
}
