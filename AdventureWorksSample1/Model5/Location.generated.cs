using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.Location")]
    public partial class Location
    {
        [Key]
        [Column("LocationID", Order = 1, TypeName = "smallint")]
        public short LocationId { get; set; }
        [Column("Name", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("CostRate", Order = 3, TypeName = "smallmoney")]
        public decimal CostRate { get; set; }
        [Column("Availability", Order = 4, TypeName = "decimal")]
        public decimal Availability { get; set; }
        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public Location()
        {
            LocationId = 0;
            Name = null;
            CostRate = 0;
            Availability = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
