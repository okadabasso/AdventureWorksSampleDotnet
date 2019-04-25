using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.SalesTerritory")]
    public partial class SalesTerritory
    {
        [Key]
        [Column("TerritoryID", Order = 1, TypeName = "int")]
        public int TerritoryId { get; set; }
        [Column("Name", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("CountryRegionCode", Order = 3, TypeName = "nvarchar")]
        [StringLength(3)]
        public string CountryRegionCode { get; set; }
        [Column("Group", Order = 4, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Group { get; set; }
        [Column("SalesYTD", Order = 5, TypeName = "money")]
        public decimal SalesYtd { get; set; }
        [Column("SalesLastYear", Order = 6, TypeName = "money")]
        public decimal SalesLastYear { get; set; }
        [Column("CostYTD", Order = 7, TypeName = "money")]
        public decimal CostYtd { get; set; }
        [Column("CostLastYear", Order = 8, TypeName = "money")]
        public decimal CostLastYear { get; set; }
        [Column("rowguid", Order = 9, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }
        [Column("ModifiedDate", Order = 10, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public SalesTerritory()
        {
            TerritoryId = 0;
            Name = null;
            CountryRegionCode = null;
            Group = null;
            SalesYtd = 0;
            SalesLastYear = 0;
            CostYtd = 0;
            CostLastYear = 0;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
