using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.SalesTerritoryHistory")]
    public partial class SalesTerritoryHistory
    {
        [Key]
        [Column("BusinessEntityID", Order = 1, TypeName = "int")]
        public int BusinessEntityId { get; set; }
        [Key]
        [Column("TerritoryID", Order = 2, TypeName = "int")]
        public int TerritoryId { get; set; }
        [Key]
        [Column("StartDate", Order = 3, TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [Column("EndDate", Order = 4, TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Column("rowguid", Order = 5, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }
        [Column("ModifiedDate", Order = 6, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public SalesTerritoryHistory()
        {
            BusinessEntityId = 0;
            TerritoryId = 0;
            StartDate = DateTime.Parse("0001/01/01 0:00:00");
            EndDate = null;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
