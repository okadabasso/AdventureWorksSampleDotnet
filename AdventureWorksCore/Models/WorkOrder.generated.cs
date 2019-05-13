using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("WorkOrder", Schema="Production")]
    public partial class WorkOrder
    {
        public WorkOrder()
        {
            WorkOrderRoutings = new HashSet<WorkOrderRouting>();

        }

        ///<summary>Primary key for WorkOrder records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("WorkOrderID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkOrderId { get; set; }

        ///<summary>Product identification number. Foreign key to Product.ProductID.</summary>
        ///<remarks></remarks>
        [Column("ProductID")]
        public int ProductId { get; set; }

        ///<summary>Product quantity to build.</summary>
        ///<remarks></remarks>
        [Column("OrderQty", Order = 2)]
        public int OrderQty { get; set; }

        ///<summary>Quantity built and put in inventory.</summary>
        ///<remarks></remarks>
        [Column("StockedQty", Order = 3)]
        public int StockedQty { get; set; }

        ///<summary>Quantity that failed inspection.</summary>
        ///<remarks></remarks>
        [Column("ScrappedQty", Order = 4)]
        public short ScrappedQty { get; set; }

        ///<summary>Work order start date.</summary>
        ///<remarks></remarks>
        [Column("StartDate", Order = 5)]
        public DateTime StartDate { get; set; }

        ///<summary>Work order end date.</summary>
        ///<remarks></remarks>
        [Column("EndDate", Order = 6)]
        public DateTime? EndDate { get; set; }

        ///<summary>Work order due date.</summary>
        ///<remarks></remarks>
        [Column("DueDate", Order = 7)]
        public DateTime DueDate { get; set; }

        ///<summary>Reason for inspection failure.</summary>
        ///<remarks></remarks>
        [Column("ScrapReasonID")]
        public short? ScrapReasonId { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 9)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }

        public virtual Product Product { get; set; }

        public virtual ScrapReason ScrapReason { get; set; }

    }
}
