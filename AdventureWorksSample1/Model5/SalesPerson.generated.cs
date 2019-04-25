using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.SalesPerson")]
    public partial class SalesPerson
    {
        [Key]
        [Column("BusinessEntityID", Order = 1, TypeName = "int")]
        public int BusinessEntityId { get; set; }
        [Column("TerritoryID", Order = 2, TypeName = "int")]
        public int? TerritoryId { get; set; }
        [Column("SalesQuota", Order = 3, TypeName = "money")]
        public decimal? SalesQuota { get; set; }
        [Column("Bonus", Order = 4, TypeName = "money")]
        public decimal Bonus { get; set; }
        [Column("CommissionPct", Order = 5, TypeName = "smallmoney")]
        public decimal CommissionPct { get; set; }
        [Column("SalesYTD", Order = 6, TypeName = "money")]
        public decimal SalesYtd { get; set; }
        [Column("SalesLastYear", Order = 7, TypeName = "money")]
        public decimal SalesLastYear { get; set; }
        [Column("rowguid", Order = 8, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }
        [Column("ModifiedDate", Order = 9, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public SalesPerson()
        {
            BusinessEntityId = 0;
            TerritoryId = null;
            SalesQuota = null;
            Bonus = 0;
            CommissionPct = 0;
            SalesYtd = 0;
            SalesLastYear = 0;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
