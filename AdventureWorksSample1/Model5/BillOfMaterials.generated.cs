using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.BillOfMaterials")]
    public partial class BillOfMaterials
    {
        [Key]
        [Column("BillOfMaterialsID", Order = 1, TypeName = "int")]
        public int BillOfMaterialsId { get; set; }
        [Column("ProductAssemblyID", Order = 2, TypeName = "int")]
        public int? ProductAssemblyId { get; set; }
        [Column("ComponentID", Order = 3, TypeName = "int")]
        public int ComponentId { get; set; }
        [Column("StartDate", Order = 4, TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [Column("EndDate", Order = 5, TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Column("UnitMeasureCode", Order = 6, TypeName = "nchar")]
        [StringLength(3)]
        public string UnitMeasureCode { get; set; }
        [Column("BOMLevel", Order = 7, TypeName = "smallint")]
        public short BomLevel { get; set; }
        [Column("PerAssemblyQty", Order = 8, TypeName = "decimal")]
        public decimal PerAssemblyQty { get; set; }
        [Column("ModifiedDate", Order = 9, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public BillOfMaterials()
        {
            BillOfMaterialsId = 0;
            ProductAssemblyId = null;
            ComponentId = 0;
            StartDate = DateTime.Parse("0001/01/01 0:00:00");
            EndDate = null;
            UnitMeasureCode = null;
            BomLevel = 0;
            PerAssemblyQty = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
