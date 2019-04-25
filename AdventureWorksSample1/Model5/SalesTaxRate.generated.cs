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
        [Key]
        [Column("SalesTaxRateID", Order = 1, TypeName = "int")]
        public int SalesTaxRateId { get; set; }
        [Column("StateProvinceID", Order = 2, TypeName = "int")]
        public int StateProvinceId { get; set; }
        [Column("TaxType", Order = 3, TypeName = "tinyint")]
        public byte TaxType { get; set; }
        [Column("TaxRate", Order = 4, TypeName = "smallmoney")]
        public decimal TaxRate { get; set; }
        [Column("Name", Order = 5, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("rowguid", Order = 6, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }
        [Column("ModifiedDate", Order = 7, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public SalesTaxRate()
        {
            SalesTaxRateId = 0;
            StateProvinceId = 0;
            TaxType = 0;
            TaxRate = 0;
            Name = null;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
