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
        public WorkOrder()
        {
            WorkOrderID = 0;
            ProductID = 0;
            OrderQty = 0;
            StockedQty = 0;
            ScrappedQty = 0;
            StartDate = DateTime.Parse("0001/01/01 0:00:00");
            EndDate = null;
            DueDate = DateTime.Parse("0001/01/01 0:00:00");
            ScrapReasonID = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            WorkOrderRoutings = new HashSet<WorkOrderRouting>();

        }

        [Key]
        [Column("WorkOrderID", Order = 0, TypeName = "int")]
        public int WorkOrderID { get; set; }

        public int ProductID { get; set; }

        [Column("OrderQty", Order = 2, TypeName = "int")]
        public int OrderQty { get; set; }

        [Column("StockedQty", Order = 3, TypeName = "int")]
        public int StockedQty { get; set; }

        [Column("ScrappedQty", Order = 4, TypeName = "smallint")]
        public short ScrappedQty { get; set; }

        [Column("StartDate", Order = 5, TypeName = "datetime")]
        public DateTime StartDate { get; set; }

        [Column("EndDate", Order = 6, TypeName = "datetime")]
        public DateTime? EndDate { get; set; }

        [Column("DueDate", Order = 7, TypeName = "datetime")]
        public DateTime DueDate { get; set; }

        public short? ScrapReasonID { get; set; }

        [Column("ModifiedDate", Order = 9, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//WorkOrderRouting WorkOrder
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }

        public virtual Product Product { get; set; }

        public virtual ScrapReason ScrapReason { get; set; }

    }
}
