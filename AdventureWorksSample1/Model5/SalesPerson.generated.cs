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
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();
            SalesPersonQuotaHistories = new HashSet<SalesPersonQuotaHistory>();
            SalesTerritoryHistories = new HashSet<SalesTerritoryHistory>();
            Stores = new HashSet<Store>();

        }

        ///<summary>Primary key for SalesPerson records. Foreign key to Employee.BusinessEntityID</summary>
        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityId { get; set; }

        ///<summary>Territory currently assigned to. Foreign key to SalesTerritory.SalesTerritoryID.</summary>
        public int? TerritoryId { get; set; }

        ///<summary>Projected yearly sales.</summary>
        [Column("SalesQuota", Order = 2, TypeName = "money")]
        public decimal? SalesQuota { get; set; }

        ///<summary>Bonus due if quota is met.</summary>
        [Column("Bonus", Order = 3, TypeName = "money")]
        public decimal Bonus { get; set; }

        ///<summary>Commision percent received per sale.</summary>
        [Column("CommissionPct", Order = 4, TypeName = "smallmoney")]
        public decimal CommissionPct { get; set; }

        ///<summary>Sales total year to date.</summary>
        [Column("SalesYTD", Order = 5, TypeName = "money")]
        public decimal SalesYtd { get; set; }

        ///<summary>Sales total of previous year.</summary>
        [Column("SalesLastYear", Order = 6, TypeName = "money")]
        public decimal SalesLastYear { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 7, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 8, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store> Stores { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual SalesTerritory SalesTerritory { get; set; }

    }
}
