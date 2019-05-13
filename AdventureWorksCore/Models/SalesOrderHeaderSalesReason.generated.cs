using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("SalesOrderHeaderSalesReason", Schema="Sales")]
    public partial class SalesOrderHeaderSalesReason
    {
        public SalesOrderHeaderSalesReason()
        {

        }

        ///<summary>Primary key. Foreign key to SalesOrderHeader.SalesOrderID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("SalesOrderID", Order = 0)]
        public int SalesOrderId { get; set; }

        ///<summary>Primary key. Foreign key to SalesReason.SalesReasonID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("SalesReasonID", Order = 1)]
        public int SalesReasonId { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 2)]
        public DateTime ModifiedDate { get; set; }

        public virtual SalesOrderHeader SalesOrderHeader { get; set; }

        public virtual SalesReason SalesReason { get; set; }

    }
}
