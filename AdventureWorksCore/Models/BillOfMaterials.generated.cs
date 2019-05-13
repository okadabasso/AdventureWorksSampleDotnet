using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("BillOfMaterials", Schema="Production")]
    public partial class BillOfMaterials
    {
        public BillOfMaterials()
        {

        }

        ///<summary>Primary key for BillOfMaterials records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("BillOfMaterialsID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillOfMaterialsId { get; set; }

        ///<summary>Parent product identification number. Foreign key to Product.ProductID.</summary>
        ///<remarks></remarks>
        [Column("ProductAssemblyID")]
        public int? ProductAssemblyId { get; set; }

        ///<summary>Component identification number. Foreign key to Product.ProductID.</summary>
        ///<remarks></remarks>
        [Column("ComponentID")]
        public int ComponentId { get; set; }

        ///<summary>Date the component started being used in the assembly item.</summary>
        ///<remarks></remarks>
        [Column("StartDate", Order = 3)]
        public DateTime StartDate { get; set; }

        ///<summary>Date the component stopped being used in the assembly item.</summary>
        ///<remarks></remarks>
        [Column("EndDate", Order = 4)]
        public DateTime? EndDate { get; set; }

        ///<summary>Standard code identifying the unit of measure for the quantity.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("UnitMeasureCode")]
        [StringLength(3)]
        public string UnitMeasureCode { get; set; }

        ///<summary>Indicates the depth the component is from its parent (AssemblyID).</summary>
        ///<remarks></remarks>
        [Column("BOMLevel", Order = 6)]
        public short BomLevel { get; set; }

        ///<summary>Quantity of the component needed to create the assembly.</summary>
        ///<remarks></remarks>
        [Column("PerAssemblyQty", Order = 7)]
        public decimal PerAssemblyQty { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 8)]
        public DateTime ModifiedDate { get; set; }

        public virtual Product ComponentProduct { get; set; }

        public virtual Product ProductAssemblyProduct { get; set; }

        public virtual UnitMeasure UnitMeasure { get; set; }

    }
}
