using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("Shift", Schema="HumanResources")]
    public partial class Shift
    {
        public Shift()
        {
            EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();

        }

        ///<summary>Primary key for Shift records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ShiftID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte ShiftId { get; set; }

        ///<summary>Shift description.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Name", Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>Shift start time.</summary>
        ///<remarks></remarks>
        [Column("StartTime", Order = 2)]
        public TimeSpan StartTime { get; set; }

        ///<summary>Shift end time.</summary>
        ///<remarks></remarks>
        [Column("EndTime", Order = 3)]
        public TimeSpan EndTime { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 4)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

    }
}
