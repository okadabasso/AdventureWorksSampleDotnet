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
        public WorkOrderRouting()
        {
            WorkOrderID = 0;
            ProductID = 0;
            OperationSequence = 0;
            LocationID = 0;
            ScheduledStartDate = DateTime.Parse("0001/01/01 0:00:00");
            ScheduledEndDate = DateTime.Parse("0001/01/01 0:00:00");
            ActualStartDate = null;
            ActualEndDate = null;
            ActualResourceHrs = null;
            PlannedCost = 0;
            ActualCost = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("WorkOrderID", Order = 0, TypeName = "int")]
        public int WorkOrderID { get; set; }

        [Key]
        [Column("ProductID", Order = 1, TypeName = "int")]
        public int ProductID { get; set; }

        [Key]
        [Column("OperationSequence", Order = 2, TypeName = "smallint")]
        public short OperationSequence { get; set; }

        public short LocationID { get; set; }

        [Column("ScheduledStartDate", Order = 4, TypeName = "datetime")]
        public DateTime ScheduledStartDate { get; set; }

        [Column("ScheduledEndDate", Order = 5, TypeName = "datetime")]
        public DateTime ScheduledEndDate { get; set; }

        [Column("ActualStartDate", Order = 6, TypeName = "datetime")]
        public DateTime? ActualStartDate { get; set; }

        [Column("ActualEndDate", Order = 7, TypeName = "datetime")]
        public DateTime? ActualEndDate { get; set; }

        [Column("ActualResourceHrs", Order = 8, TypeName = "decimal")]
        public decimal? ActualResourceHrs { get; set; }

        [Column("PlannedCost", Order = 9, TypeName = "money")]
        public decimal PlannedCost { get; set; }

        [Column("ActualCost", Order = 10, TypeName = "money")]
        public decimal? ActualCost { get; set; }

        [Column("ModifiedDate", Order = 11, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Location Location { get; set; }

        public virtual WorkOrder WorkOrder { get; set; }

    }
}
