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
        [Key]
        [Column("DepartmentID", Order = 1, TypeName = "smallint")]
        public short DepartmentId { get; set; }
        [Column("Name", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("GroupName", Order = 3, TypeName = "nvarchar")]
        [StringLength(50)]
        public string GroupName { get; set; }
        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public Department()
        {
            DepartmentId = 0;
            Name = null;
            GroupName = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
