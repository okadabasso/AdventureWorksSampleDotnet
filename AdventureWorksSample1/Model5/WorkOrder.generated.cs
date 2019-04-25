using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.WorkOrder")]
    public partial class WorkOrder
    {
        [Key]
        [Column("WorkOrderID", Order = 1, TypeName = "int")]
        public int WorkOrderId { get; set; }
        [Column("ProductID", Order = 2, TypeName = "int")]
        public int ProductId { get; set; }
        [Column("OrderQty", Order = 3, TypeName = "int")]
        public int OrderQty { get; set; }
        [Column("StockedQty", Order = 4, TypeName = "int")]
        public int StockedQty { get; set; }
        [Column("ScrappedQty", Order = 5, TypeName = "smallint")]
        public short ScrappedQty { get; set; }
        [Column("StartDate", Order = 6, TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [Column("EndDate", Order = 7, TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Column("DueDate", Order = 8, TypeName = "datetime")]
        public DateTime DueDate { get; set; }
        [Column("ScrapReasonID", Order = 9, TypeName = "smallint")]
        public short? ScrapReasonId { get; set; }
        [Column("ModifiedDate", Order = 10, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public WorkOrder()
        {
            WorkOrderId = 0;
            ProductId = 0;
            OrderQty = 0;
            StockedQty = 0;
            ScrappedQty = 0;
            StartDate = DateTime.Parse("0001/01/01 0:00:00");
            EndDate = null;
            DueDate = DateTime.Parse("0001/01/01 0:00:00");
            ScrapReasonId = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
