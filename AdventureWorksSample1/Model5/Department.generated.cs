using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("HumanResources.Department")]
    public partial class Department
    {
        public Department()
        {
            DepartmentId = 0;
            Name = null;
            GroupName = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();

        }

        ///<summary>Primary key for Department records.</summary>
        [Key]
        [Column("DepartmentID", Order = 0, TypeName = "smallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short DepartmentId { get; set; }

        ///<summary>Name of the department.</summary>
        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>Name of the group to which the department belongs.</summary>
        [Required]
        [Column("GroupName", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string GroupName { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

    }
}
