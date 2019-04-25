using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Purchasing.ShipMethod")]
    public partial class ShipMethod
    {
        [Key]
        [Column("ShipMethodID", Order = 1, TypeName = "int")]
        public int ShipMethodId { get; set; }
        [Column("Name", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("ShipBase", Order = 3, TypeName = "money")]
        public decimal ShipBase { get; set; }
        [Column("ShipRate", Order = 4, TypeName = "money")]
        public decimal ShipRate { get; set; }
        [Column("rowguid", Order = 5, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }
        [Column("ModifiedDate", Order = 6, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public ShipMethod()
        {
            ShipMethodId = 0;
            Name = null;
            ShipBase = 0;
            ShipRate = 0;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
