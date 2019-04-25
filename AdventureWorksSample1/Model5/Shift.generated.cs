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
        [Key]
        [Column("ShiftID", Order = 1, TypeName = "tinyint")]
        public byte ShiftId { get; set; }
        [Column("Name", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("StartTime", Order = 3, TypeName = "time")]
        public TimeSpan StartTime { get; set; }
        [Column("EndTime", Order = 4, TypeName = "time")]
        public TimeSpan EndTime { get; set; }
        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public Shift()
        {
            ShiftId = 0;
            Name = null;
            StartTime = TimeSpan.Parse("00:00:00");
            EndTime = TimeSpan.Parse("00:00:00");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
