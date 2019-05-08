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
            ShiftId = 0;
            Name = null;
            StartTime = TimeSpan.Parse("00:00:00");
            EndTime = TimeSpan.Parse("00:00:00");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();

        }

        ///<summary>Primary key for Shift records.</summary>
        [Key]
        [Column("ShiftID", Order = 0, TypeName = "tinyint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte ShiftId { get; set; }

        ///<summary>Shift description.</summary>
        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>Shift start time.</summary>
        [Column("StartTime", Order = 2, TypeName = "time")]
        public TimeSpan StartTime { get; set; }

        ///<summary>Shift end time.</summary>
        [Column("EndTime", Order = 3, TypeName = "time")]
        public TimeSpan EndTime { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

    }
}
