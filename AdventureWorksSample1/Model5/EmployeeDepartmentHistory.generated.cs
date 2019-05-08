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
            BusinessEntityId = 0;
            DepartmentId = 0;
            ShiftId = 0;
            StartDate = DateTime.Parse("0001/01/01 0:00:00");
            EndDate = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Employee identification number. Foreign key to Employee.BusinessEntityID.</summary>
        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityId { get; set; }

        ///<summary>Department in which the employee worked including currently. Foreign key to Department.DepartmentID.</summary>
        [Key]
        [Column("DepartmentID", Order = 1, TypeName = "smallint")]
        public short DepartmentId { get; set; }

        ///<summary>Identifies which 8-hour shift the employee works. Foreign key to Shift.Shift.ID.</summary>
        [Key]
        [Column("ShiftID", Order = 2, TypeName = "tinyint")]
        public byte ShiftId { get; set; }

        ///<summary>Date the employee started work in the department.</summary>
        [Key]
        [Column("StartDate", Order = 3, TypeName = "date")]
        public DateTime StartDate { get; set; }

        ///<summary>Date the employee left the department. NULL = Current department.</summary>
        [Column("EndDate", Order = 4, TypeName = "date")]
        public DateTime? EndDate { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Department Department { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Shift Shift { get; set; }

    }
}
