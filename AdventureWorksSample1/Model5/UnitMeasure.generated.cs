using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.UnitMeasure")]
    public partial class UnitMeasure
    {
        [Key]
        [Column("UnitMeasureCode", Order = 1, TypeName = "nchar")]
        [StringLength(3)]
        public string UnitMeasureCode { get; set; }
        [Column("Name", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public UnitMeasure()
        {
            UnitMeasureCode = null;
            Name = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
