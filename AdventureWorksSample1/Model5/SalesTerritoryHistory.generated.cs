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
        public SalesTerritoryHistory()
        {
            BusinessEntityID = 0;
            TerritoryID = 0;
            StartDate = DateTime.Parse("0001/01/01 0:00:00");
            EndDate = null;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityID { get; set; }

        [Key]
        [Column("TerritoryID", Order = 1, TypeName = "int")]
        public int TerritoryID { get; set; }

        [Key]
        [Column("StartDate", Order = 2, TypeName = "datetime")]
        public DateTime StartDate { get; set; }

        [Column("EndDate", Order = 3, TypeName = "datetime")]
        public DateTime? EndDate { get; set; }

        [Column("rowguid", Order = 4, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual SalesPerson SalesPerson { get; set; }

        public virtual SalesTerritory SalesTerritory { get; set; }

    }
}
