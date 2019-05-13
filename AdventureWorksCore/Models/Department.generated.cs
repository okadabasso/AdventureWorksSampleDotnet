using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("Department", Schema="HumanResources")]
    public partial class Department
    {
        public Department()
        {
            EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();

        }

        ///<summary>Primary key for Department records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("DepartmentID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short DepartmentId { get; set; }

        ///<summary>Name of the department.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Name", Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>Name of the group to which the department belongs.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("GroupName", Order = 2)]
        [StringLength(50)]
        public string GroupName { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 3)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

    }
}
