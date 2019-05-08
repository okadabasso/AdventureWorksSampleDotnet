using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Production.WorkOrder")]
    public partial class WorkOrder
    {
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
            WorkOrderRoutings = new HashSet<WorkOrderRouting>();

        }

        ///<summary>Primary key for WorkOrder records.</summary>
        [Key]
        [Column("WorkOrderID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkOrderId { get; set; }

        ///<summary>Product identification number. Foreign key to Product.ProductID.</summary>
        [Column("ProductID")]
        public int ProductId { get; set; }

        ///<summary>Product quantity to build.</summary>
        [Column("OrderQty", Order = 2, TypeName = "int")]
        public int OrderQty { get; set; }

        ///<summary>Quantity built and put in inventory.</summary>
        [Column("StockedQty", Order = 3, TypeName = "int")]
        public int StockedQty { get; set; }

        ///<summary>Quantity that failed inspection.</summary>
        [Column("ScrappedQty", Order = 4, TypeName = "smallint")]
        public short ScrappedQty { get; set; }

        ///<summary>Work order start date.</summary>
        [Column("StartDate", Order = 5, TypeName = "datetime")]
        public DateTime StartDate { get; set; }

        ///<summary>Work order end date.</summary>
        [Column("EndDate", Order = 6, TypeName = "datetime")]
        public DateTime? EndDate { get; set; }

        ///<summary>Work order due date.</summary>
        [Column("DueDate", Order = 7, TypeName = "datetime")]
        public DateTime DueDate { get; set; }

        ///<summary>Reason for inspection failure.</summary>
        [Column("ScrapReasonID")]
        public short? ScrapReasonId { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 9, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }

        public virtual Product Product { get; set; }

        public virtual ScrapReason ScrapReason { get; set; }

    }
}
