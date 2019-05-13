using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("WorkOrderRouting", Schema="Production")]
    public partial class WorkOrderRouting
    {
        public WorkOrderRouting()
        {

        }

        ///<summary>Primary key. Foreign key to WorkOrder.WorkOrderID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("WorkOrderID", Order = 0)]
        public int WorkOrderId { get; set; }

        ///<summary>Primary key. Foreign key to Product.ProductID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ProductID", Order = 1)]
        public int ProductId { get; set; }

        ///<summary>Primary key. Indicates the manufacturing process sequence.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("OperationSequence", Order = 2)]
        public short OperationSequence { get; set; }

        ///<summary>Manufacturing location where the part is processed. Foreign key to Location.LocationID.</summary>
        ///<remarks></remarks>
        [Column("LocationID")]
        public short LocationId { get; set; }

        ///<summary>Planned manufacturing start date.</summary>
        ///<remarks></remarks>
        [Column("ScheduledStartDate", Order = 4)]
        public DateTime ScheduledStartDate { get; set; }

        ///<summary>Planned manufacturing end date.</summary>
        ///<remarks></remarks>
        [Column("ScheduledEndDate", Order = 5)]
        public DateTime ScheduledEndDate { get; set; }

        ///<summary>Actual start date.</summary>
        ///<remarks></remarks>
        [Column("ActualStartDate", Order = 6)]
        public DateTime? ActualStartDate { get; set; }

        ///<summary>Actual end date.</summary>
        ///<remarks></remarks>
        [Column("ActualEndDate", Order = 7)]
        public DateTime? ActualEndDate { get; set; }

        ///<summary>Number of manufacturing hours used.</summary>
        ///<remarks></remarks>
        [Column("ActualResourceHrs", Order = 8)]
        public decimal? ActualResourceHrs { get; set; }

        ///<summary>Estimated manufacturing cost.</summary>
        ///<remarks></remarks>
        [Column("PlannedCost", Order = 9)]
        public decimal PlannedCost { get; set; }

        ///<summary>Actual manufacturing cost.</summary>
        ///<remarks></remarks>
        [Column("ActualCost", Order = 10)]
        public decimal? ActualCost { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 11)]
        public DateTime ModifiedDate { get; set; }

        public virtual Location Location { get; set; }

        public virtual WorkOrder WorkOrder { get; set; }

    }
}
