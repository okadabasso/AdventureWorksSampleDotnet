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
            SalesOrderId = 0;
            SalesReasonId = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Primary key. Foreign key to SalesOrderHeader.SalesOrderID.</summary>
        [Key]
        [Column("SalesOrderID", Order = 0, TypeName = "int")]
        public int SalesOrderId { get; set; }

        ///<summary>Primary key. Foreign key to SalesReason.SalesReasonID.</summary>
        [Key]
        [Column("SalesReasonID", Order = 1, TypeName = "int")]
        public int SalesReasonId { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 2, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual SalesOrderHeader SalesOrderHeader { get; set; }

        public virtual SalesReason SalesReason { get; set; }

    }
}
