using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("EmployeeDepartmentHistory", Schema="HumanResources")]
    public partial class EmployeeDepartmentHistory
    {
        public EmployeeDepartmentHistory()
        {

        }

        ///<summary>Employee identification number. Foreign key to Employee.BusinessEntityID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("BusinessEntityID", Order = 0)]
        public int BusinessEntityId { get; set; }

        ///<summary>Department in which the employee worked including currently. Foreign key to Department.DepartmentID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("DepartmentID", Order = 1)]
        public short DepartmentId { get; set; }

        ///<summary>Identifies which 8-hour shift the employee works. Foreign key to Shift.Shift.ID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ShiftID", Order = 2)]
        public byte ShiftId { get; set; }

        ///<summary>Date the employee started work in the department.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("StartDate", Order = 3)]
        public DateTime StartDate { get; set; }

        ///<summary>Date the employee left the department. NULL = Current department.</summary>
        ///<remarks></remarks>
        [Column("EndDate", Order = 4)]
        public DateTime? EndDate { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 5)]
        public DateTime ModifiedDate { get; set; }

        public virtual Department Department { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Shift Shift { get; set; }

    }
}
