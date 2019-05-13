using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("StateProvince", Schema="Person")]
    public partial class StateProvince
    {
        public StateProvince()
        {
            Addresses = new HashSet<Address>();
            SalesTaxRates = new HashSet<SalesTaxRate>();

        }

        ///<summary>Primary key for StateProvince records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("StateProvinceID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StateProvinceId { get; set; }

        ///<summary>ISO standard state or province code.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("StateProvinceCode", Order = 1)]
        [StringLength(3)]
        public string StateProvinceCode { get; set; }

        ///<summary>ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode. </summary>
        ///<remarks></remarks>
        [Required]
        [Column("CountryRegionCode")]
        [StringLength(3)]
        public string CountryRegionCode { get; set; }

        ///<summary>0 = StateProvinceCode exists. 1 = StateProvinceCode unavailable, using CountryRegionCode.</summary>
        ///<remarks></remarks>
        [Column("IsOnlyStateProvinceFlag", Order = 3)]
        public bool IsOnlyStateProvinceFlag { get; set; }

        ///<summary>State or province description.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Name", Order = 4)]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>ID of the territory in which the state or province is located. Foreign key to SalesTerritory.SalesTerritoryID.</summary>
        ///<remarks></remarks>
        [Column("TerritoryID")]
        public int TerritoryId { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 6)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 7)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Address> Addresses { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesTaxRate> SalesTaxRates { get; set; }

        public virtual CountryRegion CountryRegion { get; set; }

        public virtual SalesTerritory SalesTerritory { get; set; }

    }
}
