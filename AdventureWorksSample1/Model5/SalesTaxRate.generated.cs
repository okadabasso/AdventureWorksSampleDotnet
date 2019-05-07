using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.SalesTaxRate")]
    public partial class SalesTaxRate
    {
        public SalesTaxRate()
        {
            SalesTaxRateID = 0;
            StateProvinceID = 0;
            TaxType = 0;
            TaxRate = 0;
            Name = null;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("SalesTaxRateID", Order = 0, TypeName = "int")]
        public int SalesTaxRateID { get; set; }

        public int StateProvinceID { get; set; }

        [Column("TaxType", Order = 2, TypeName = "tinyint")]
        public byte TaxType { get; set; }

        [Column("TaxRate", Order = 3, TypeName = "smallmoney")]
        public decimal TaxRate { get; set; }

        [Required]
        [Column("Name", Order = 4, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("rowguid", Order = 5, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 6, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual StateProvince StateProvince { get; set; }

    }
}
