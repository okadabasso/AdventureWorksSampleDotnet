using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("SalesPerson", Schema="Sales")]
    public partial class SalesPerson
    {
        public SalesPerson()
        {
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();
            SalesPersonQuotaHistories = new HashSet<SalesPersonQuotaHistory>();
            SalesTerritoryHistories = new HashSet<SalesTerritoryHistory>();
            Stores = new HashSet<Store>();

        }

        ///<summary>Primary key for SalesPerson records. Foreign key to Employee.BusinessEntityID</summary>
        ///<remarks></remarks>
        [Key]
        [Column("BusinessEntityID", Order = 0)]
        public int BusinessEntityId { get; set; }

        ///<summary>Territory currently assigned to. Foreign key to SalesTerritory.SalesTerritoryID.</summary>
        ///<remarks></remarks>
        [Column("TerritoryID")]
        public int? TerritoryId { get; set; }

        ///<summary>Projected yearly sales.</summary>
        ///<remarks></remarks>
        [Column("SalesQuota", Order = 2)]
        public decimal? SalesQuota { get; set; }

        ///<summary>Bonus due if quota is met.</summary>
        ///<remarks></remarks>
        [Column("Bonus", Order = 3)]
        public decimal Bonus { get; set; }

        ///<summary>Commision percent received per sale.</summary>
        ///<remarks></remarks>
        [Column("CommissionPct", Order = 4)]
        public decimal CommissionPct { get; set; }

        ///<summary>Sales total year to date.</summary>
        ///<remarks></remarks>
        [Column("SalesYTD", Order = 5)]
        public decimal SalesYtd { get; set; }

        ///<summary>Sales total of previous year.</summary>
        ///<remarks></remarks>
        [Column("SalesLastYear", Order = 6)]
        public decimal SalesLastYear { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 7)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 8)]
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
