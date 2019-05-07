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
            BusinessEntityID = 0;
            TerritoryID = null;
            SalesQuota = null;
            Bonus = 0;
            CommissionPct = 0;
            SalesYTD = 0;
            SalesLastYear = 0;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            SalesOrderHeaders = new HashSet<SalesOrderHeader>();
            SalesPersonQuotaHistories = new HashSet<SalesPersonQuotaHistory>();
            SalesTerritoryHistories = new HashSet<SalesTerritoryHistory>();
            Stores = new HashSet<Store>();

        }

        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityID { get; set; }

        public int? TerritoryID { get; set; }

        [Column("SalesQuota", Order = 2, TypeName = "money")]
        public decimal? SalesQuota { get; set; }

        [Column("Bonus", Order = 3, TypeName = "money")]
        public decimal Bonus { get; set; }

        [Column("CommissionPct", Order = 4, TypeName = "smallmoney")]
        public decimal CommissionPct { get; set; }

        [Column("SalesYTD", Order = 5, TypeName = "money")]
        public decimal SalesYTD { get; set; }

        [Column("SalesLastYear", Order = 6, TypeName = "money")]
        public decimal SalesLastYear { get; set; }

        [Column("rowguid", Order = 7, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 8, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//SalesOrderHeader SalesPerson
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

//SalesPersonQuotaHistory SalesPerson
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }

//SalesTerritoryHistory SalesPerson
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }

//Store SalesPerson
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store> Stores { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual SalesTerritory SalesTerritory { get; set; }

    }
}
