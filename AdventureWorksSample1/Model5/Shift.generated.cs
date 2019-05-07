using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("HumanResources.Shift")]
    public partial class Shift
    {
        public Shift()
        {
            ShiftID = 0;
            Name = null;
            StartTime = TimeSpan.Parse("00:00:00");
            EndTime = TimeSpan.Parse("00:00:00");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();

        }

        [Key]
        [Column("ShiftID", Order = 0, TypeName = "tinyint")]
        public byte ShiftID { get; set; }

        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("StartTime", Order = 2, TypeName = "time")]
        public TimeSpan StartTime { get; set; }

        [Column("EndTime", Order = 3, TypeName = "time")]
        public TimeSpan EndTime { get; set; }

        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//EmployeeDepartmentHistory Shift
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

    }
}
