using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("SalesTerritoryHistory", Schema="Sales")]
    public partial class SalesTerritoryHistory
    {
        public SalesTerritoryHistory()
        {

        }

        ///<summary>Primary key. The sales rep.  Foreign key to SalesPerson.BusinessEntityID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("BusinessEntityID", Order = 0)]
        public int BusinessEntityId { get; set; }

        ///<summary>Primary key. Territory identification number. Foreign key to SalesTerritory.SalesTerritoryID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("TerritoryID", Order = 1)]
        public int TerritoryId { get; set; }

        ///<summary>Primary key. Date the sales representive started work in the territory.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("StartDate", Order = 2)]
        public DateTime StartDate { get; set; }

        ///<summary>Date the sales representative left work in the territory.</summary>
        ///<remarks></remarks>
        [Column("EndDate", Order = 3)]
        public DateTime? EndDate { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 4)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 5)]
        public DateTime ModifiedDate { get; set; }

        public virtual SalesPerson SalesPerson { get; set; }

        public virtual SalesTerritory SalesTerritory { get; set; }

    }
}
