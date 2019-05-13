using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Production.BillOfMaterials")]
    public partial class BillOfMaterials
    {
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

        ///<summary>Primary key for BillOfMaterials records.</summary>
        [Key]
        [Column("BillOfMaterialsID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillOfMaterialsId { get; set; }

        ///<summary>Parent product identification number. Foreign key to Product.ProductID.</summary>
        [Column("ProductAssemblyID")]
        public int? ProductAssemblyId { get; set; }

        ///<summary>Component identification number. Foreign key to Product.ProductID.</summary>
        [Column("ComponentID")]
        public int ComponentId { get; set; }

        ///<summary>Date the component started being used in the assembly item.</summary>
        [Column("StartDate", Order = 3, TypeName = "datetime")]
        public DateTime StartDate { get; set; }

        ///<summary>Date the component stopped being used in the assembly item.</summary>
        [Column("EndDate", Order = 4, TypeName = "datetime")]
        public DateTime? EndDate { get; set; }

        ///<summary>Standard code identifying the unit of measure for the quantity.</summary>
        [Required]
        [Column("UnitMeasureCode")]
        [StringLength(3)]
        public string UnitMeasureCode { get; set; }

        ///<summary>Indicates the depth the component is from its parent (AssemblyID).</summary>
        [Column("BOMLevel", Order = 6, TypeName = "smallint")]
        public short BomLevel { get; set; }

        ///<summary>Quantity of the component needed to create the assembly.</summary>
        [Column("PerAssemblyQty", Order = 7, TypeName = "decimal")]
        public decimal PerAssemblyQty { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 8, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Product ComponentProduct { get; set; }

        public virtual Product ProductAssemblyProduct { get; set; }

        public virtual UnitMeasure UnitMeasure { get; set; }

    }
}
