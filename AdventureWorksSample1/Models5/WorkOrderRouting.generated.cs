using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Production.WorkOrderRouting")]
    public partial class WorkOrderRouting
    {
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

        ///<summary>Primary key. Foreign key to WorkOrder.WorkOrderID.</summary>
        [Key]
        [Column("WorkOrderID", Order = 0, TypeName = "int")]
        public int WorkOrderId { get; set; }

        ///<summary>Primary key. Foreign key to Product.ProductID.</summary>
        [Key]
        [Column("ProductID", Order = 1, TypeName = "int")]
        public int ProductId { get; set; }

        ///<summary>Primary key. Indicates the manufacturing process sequence.</summary>
        [Key]
        [Column("OperationSequence", Order = 2, TypeName = "smallint")]
        public short OperationSequence { get; set; }

        ///<summary>Manufacturing location where the part is processed. Foreign key to Location.LocationID.</summary>
        [Column("LocationID")]
        public short LocationId { get; set; }

        ///<summary>Planned manufacturing start date.</summary>
        [Column("ScheduledStartDate", Order = 4, TypeName = "datetime")]
        public DateTime ScheduledStartDate { get; set; }

        ///<summary>Planned manufacturing end date.</summary>
        [Column("ScheduledEndDate", Order = 5, TypeName = "datetime")]
        public DateTime ScheduledEndDate { get; set; }

        ///<summary>Actual start date.</summary>
        [Column("ActualStartDate", Order = 6, TypeName = "datetime")]
        public DateTime? ActualStartDate { get; set; }

        ///<summary>Actual end date.</summary>
        [Column("ActualEndDate", Order = 7, TypeName = "datetime")]
        public DateTime? ActualEndDate { get; set; }

        ///<summary>Number of manufacturing hours used.</summary>
        [Column("ActualResourceHrs", Order = 8, TypeName = "decimal")]
        public decimal? ActualResourceHrs { get; set; }

        ///<summary>Estimated manufacturing cost.</summary>
        [Column("PlannedCost", Order = 9, TypeName = "money")]
        public decimal PlannedCost { get; set; }

        ///<summary>Actual manufacturing cost.</summary>
        [Column("ActualCost", Order = 10, TypeName = "money")]
        public decimal? ActualCost { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 11, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Location Location { get; set; }

        public virtual WorkOrder WorkOrder { get; set; }

    }
}
