using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("HumanResources.EmployeeDepartmentHistory")]
    public partial class EmployeeDepartmentHistory
    {
        public EmployeeDepartmentHistory()
        {
            BusinessEntityID = 0;
            DepartmentID = 0;
            ShiftID = 0;
            StartDate = DateTime.Parse("0001/01/01 0:00:00");
            EndDate = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityID { get; set; }

        [Key]
        [Column("DepartmentID", Order = 1, TypeName = "smallint")]
        public short DepartmentID { get; set; }

        [Key]
        [Column("ShiftID", Order = 2, TypeName = "tinyint")]
        public byte ShiftID { get; set; }

        [Key]
        [Column("StartDate", Order = 3, TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Column("EndDate", Order = 4, TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Department Department { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Shift Shift { get; set; }

    }
}
