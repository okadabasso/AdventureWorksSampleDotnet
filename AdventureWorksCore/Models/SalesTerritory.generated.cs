using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("SalesTerritory", Schema="Sales")]
    public partial class SalesTerritory
    {
        public SalesTerritory()
        {
            StateProvinces = new HashSet<StateProvince>();
            Customers = new HashSet<Customer>();
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();
            SalesPersons = new HashSet<SalesPerson>();
            SalesTerritoryHistories = new HashSet<SalesTerritoryHistory>();

        }

        ///<summary>Primary key for SalesTerritory records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("TerritoryID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TerritoryId { get; set; }

        ///<summary>Sales territory description</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Name", Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode. </summary>
        ///<remarks></remarks>
        [Required]
        [Column("CountryRegionCode")]
        [StringLength(3)]
        public string CountryRegionCode { get; set; }

        ///<summary>Geographic area to which the sales territory belong.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Group", Order = 3)]
        [StringLength(50)]
        public string Group { get; set; }

        ///<summary>Sales in the territory year to date.</summary>
        ///<remarks></remarks>
        [Column("SalesYTD", Order = 4)]
        public decimal SalesYtd { get; set; }

        ///<summary>Sales in the territory the previous year.</summary>
        ///<remarks></remarks>
        [Column("SalesLastYear", Order = 5)]
        public decimal SalesLastYear { get; set; }

        ///<summary>Business costs in the territory year to date.</summary>
        ///<remarks></remarks>
        [Column("CostYTD", Order = 6)]
        public decimal CostYtd { get; set; }

        ///<summary>Business costs in the territory the previous year.</summary>
        ///<remarks></remarks>
        [Column("CostLastYear", Order = 7)]
        public decimal CostLastYear { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 8)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 9)]
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
