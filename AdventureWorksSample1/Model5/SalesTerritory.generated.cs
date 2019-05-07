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
        public SalesTerritory()
        {
            TerritoryID = 0;
            Name = null;
            CountryRegionCode = null;
            Group = null;
            SalesYTD = 0;
            SalesLastYear = 0;
            CostYTD = 0;
            CostLastYear = 0;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            StateProvinces = new HashSet<StateProvince>();
            Customers = new HashSet<Customer>();
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();
            SalesPersons = new HashSet<SalesPerson>();
            SalesTerritoryHistories = new HashSet<SalesTerritoryHistory>();

        }

        [Key]
        [Column("TerritoryID", Order = 0, TypeName = "int")]
        public int TerritoryID { get; set; }

        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(3)]
        public string CountryRegionCode { get; set; }

        [Required]
        [Column("Group", Order = 3, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Group { get; set; }

        [Column("SalesYTD", Order = 4, TypeName = "money")]
        public decimal SalesYTD { get; set; }

        [Column("SalesLastYear", Order = 5, TypeName = "money")]
        public decimal SalesLastYear { get; set; }

        [Column("CostYTD", Order = 6, TypeName = "money")]
        public decimal CostYTD { get; set; }

        [Column("CostLastYear", Order = 7, TypeName = "money")]
        public decimal CostLastYear { get; set; }

        [Column("rowguid", Order = 8, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 9, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//StateProvince SalesTerritory
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StateProvince> StateProvinces { get; set; }

//Customer SalesTerritory
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }

//SalesOrderHeader SalesTerritory
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

//SalesPerson SalesTerritory
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesPerson> SalesPersons { get; set; }

//SalesTerritoryHistory SalesTerritory
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }

        public virtual CountryRegion CountryRegion { get; set; }

    }
}
