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
        public BillOfMaterials()
        {
            BillOfMaterialsID = 0;
            ProductAssemblyID = null;
            ComponentID = 0;
            StartDate = DateTime.Parse("0001/01/01 0:00:00");
            EndDate = null;
            UnitMeasureCode = null;
            BOMLevel = 0;
            PerAssemblyQty = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("BillOfMaterialsID", Order = 0, TypeName = "int")]
        public int BillOfMaterialsID { get; set; }

        public int? ProductAssemblyID { get; set; }

        public int ComponentID { get; set; }

        [Column("StartDate", Order = 3, TypeName = "datetime")]
        public DateTime StartDate { get; set; }

        [Column("EndDate", Order = 4, TypeName = "datetime")]
        public DateTime? EndDate { get; set; }

        [Required]
        [StringLength(3)]
        public string UnitMeasureCode { get; set; }

        [Column("BOMLevel", Order = 6, TypeName = "smallint")]
        public short BOMLevel { get; set; }

        [Column("PerAssemblyQty", Order = 7, TypeName = "decimal")]
        public decimal PerAssemblyQty { get; set; }

        [Column("ModifiedDate", Order = 8, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

        public virtual Product Product1 { get; set; }

        public virtual UnitMeasure UnitMeasure { get; set; }

    }
}
