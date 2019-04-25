using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.WorkOrderRouting")]
    public partial class WorkOrderRouting
    {
        [Key]
        [Column("WorkOrderID", Order = 1, TypeName = "int")]
        public int WorkOrderId { get; set; }
        [Key]
        [Column("ProductID", Order = 2, TypeName = "int")]
        public int ProductId { get; set; }
        [Key]
        [Column("OperationSequence", Order = 3, TypeName = "smallint")]
        public short OperationSequence { get; set; }
        [Column("LocationID", Order = 4, TypeName = "smallint")]
        public short LocationId { get; set; }
        [Column("ScheduledStartDate", Order = 5, TypeName = "datetime")]
        public DateTime ScheduledStartDate { get; set; }
        [Column("ScheduledEndDate", Order = 6, TypeName = "datetime")]
        public DateTime ScheduledEndDate { get; set; }
        [Column("ActualStartDate", Order = 7, TypeName = "datetime")]
        public DateTime? ActualStartDate { get; set; }
        [Column("ActualEndDate", Order = 8, TypeName = "datetime")]
        public DateTime? ActualEndDate { get; set; }
        [Column("ActualResourceHrs", Order = 9, TypeName = "decimal")]
        public decimal? ActualResourceHrs { get; set; }
        [Column("PlannedCost", Order = 10, TypeName = "money")]
        public decimal PlannedCost { get; set; }
        [Column("ActualCost", Order = 11, TypeName = "money")]
        public decimal? ActualCost { get; set; }
        [Column("ModifiedDate", Order = 12, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public WorkOrderRouting()
        {
            WorkOrderId = 0;
            ProductId = 0;
            OperationSequence = 0;
            LocationId = 0;
            ScheduledStartDate = DateTime.Parse("0001/01/01 0:00:00");
            ScheduledEndDate = DateTime.Parse("0001/01/01 0:00:00");
            ActualStartDate = null;
            ActualEndDate = null;
            ActualResourceHrs = null;
            PlannedCost = 0;
            ActualCost = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
