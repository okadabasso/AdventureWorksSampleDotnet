using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Sales.SalesTerritory")]
    public partial class SalesTerritory
    {
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
            StateProvinces = new HashSet<StateProvince>();
            Customers = new HashSet<Customer>();
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();
            SalesPersons = new HashSet<SalesPerson>();
            SalesTerritoryHistories = new HashSet<SalesTerritoryHistory>();

        }

        ///<summary>Primary key for SalesTerritory records.</summary>
        [Key]
        [Column("TerritoryID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TerritoryId { get; set; }

        ///<summary>Sales territory description</summary>
        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode. </summary>
        [Required]
        [Column("CountryRegionCode")]
        [StringLength(3)]
        public string CountryRegionCode { get; set; }

        ///<summary>Geographic area to which the sales territory belong.</summary>
        [Required]
        [Column("Group", Order = 3, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Group { get; set; }

        ///<summary>Sales in the territory year to date.</summary>
        [Column("SalesYTD", Order = 4, TypeName = "money")]
        public decimal SalesYtd { get; set; }

        ///<summary>Sales in the territory the previous year.</summary>
        [Column("SalesLastYear", Order = 5, TypeName = "money")]
        public decimal SalesLastYear { get; set; }

        ///<summary>Business costs in the territory year to date.</summary>
        [Column("CostYTD", Order = 6, TypeName = "money")]
        public decimal CostYtd { get; set; }

        ///<summary>Business costs in the territory the previous year.</summary>
        [Column("CostLastYear", Order = 7, TypeName = "money")]
        public decimal CostLastYear { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 8, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 9, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StateProvince> StateProvinces { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesPerson> SalesPersons { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }

        public virtual CountryRegion CountryRegion { get; set; }

    }
}
