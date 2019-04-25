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
        [Key]
        [Column("BusinessEntityID", Order = 1, TypeName = "int")]
        public int BusinessEntityId { get; set; }
        [Key]
        [Column("DepartmentID", Order = 2, TypeName = "smallint")]
        public short DepartmentId { get; set; }
        [Key]
        [Column("ShiftID", Order = 3, TypeName = "tinyint")]
        public byte ShiftId { get; set; }
        [Key]
        [Column("StartDate", Order = 4, TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column("EndDate", Order = 5, TypeName = "date")]
        public DateTime? EndDate { get; set; }
        [Column("ModifiedDate", Order = 6, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public EmployeeDepartmentHistory()
        {
            BusinessEntityId = 0;
            DepartmentId = 0;
            ShiftId = 0;
            StartDate = DateTime.Parse("0001/01/01 0:00:00");
            EndDate = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
