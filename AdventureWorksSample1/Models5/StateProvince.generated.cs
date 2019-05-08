using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Person.StateProvince")]
    public partial class StateProvince
    {
        public StateProvince()
        {
            StateProvinceId = 0;
            StateProvinceCode = null;
            CountryRegionCode = null;
            IsOnlyStateProvinceFlag = false;
            Name = null;
            TerritoryId = 0;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            Addresses = new HashSet<Address>();
            SalesTaxRates = new HashSet<SalesTaxRate>();

        }

        ///<summary>Primary key for StateProvince records.</summary>
        [Key]
        [Column("StateProvinceID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StateProvinceId { get; set; }

        ///<summary>ISO standard state or province code.</summary>
        [Required]
        [Column("StateProvinceCode", Order = 1, TypeName = "nchar")]
        [StringLength(3)]
        public string StateProvinceCode { get; set; }

        ///<summary>ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode. </summary>
        [Required]
        [Column("CountryRegionCode")]
        [StringLength(3)]
        public string CountryRegionCode { get; set; }

        ///<summary>0 = StateProvinceCode exists. 1 = StateProvinceCode unavailable, using CountryRegionCode.</summary>
        [Column("IsOnlyStateProvinceFlag", Order = 3, TypeName = "bit")]
        public bool IsOnlyStateProvinceFlag { get; set; }

        ///<summary>State or province description.</summary>
        [Required]
        [Column("Name", Order = 4, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>ID of the territory in which the state or province is located. Foreign key to SalesTerritory.SalesTerritoryID.</summary>
        [Column("TerritoryID")]
        public int TerritoryId { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 6, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 7, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Address> Addresses { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesTaxRate> SalesTaxRates { get; set; }

        public virtual CountryRegion CountryRegion { get; set; }

        public virtual SalesTerritory SalesTerritory { get; set; }

    }
}
