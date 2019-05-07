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
            DepartmentID = 0;
            Name = null;
            GroupName = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();

        }

        [Key]
        [Column("DepartmentID", Order = 0, TypeName = "smallint")]
        public short DepartmentID { get; set; }

        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Column("GroupName", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string GroupName { get; set; }

        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//EmployeeDepartmentHistory Department
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

    }
}
