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
            BusinessEntityId = 0;
            TerritoryId = 0;
            StartDate = DateTime.Parse("0001/01/01 0:00:00");
            EndDate = null;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Primary key. The sales rep.  Foreign key to SalesPerson.BusinessEntityID.</summary>
        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityId { get; set; }

        ///<summary>Primary key. Territory identification number. Foreign key to SalesTerritory.SalesTerritoryID.</summary>
        [Key]
        [Column("TerritoryID", Order = 1, TypeName = "int")]
        public int TerritoryId { get; set; }

        ///<summary>Primary key. Date the sales representive started work in the territory.</summary>
        [Key]
        [Column("StartDate", Order = 2, TypeName = "datetime")]
        public DateTime StartDate { get; set; }

        ///<summary>Date the sales representative left work in the territory.</summary>
        [Column("EndDate", Order = 3, TypeName = "datetime")]
        public DateTime? EndDate { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 4, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual SalesPerson SalesPerson { get; set; }

        public virtual SalesTerritory SalesTerritory { get; set; }

    }
}
