using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Person.StateProvince")]
    public partial class StateProvince
    {
        public StateProvince()
        {
            StateProvinceID = 0;
            StateProvinceCode = null;
            CountryRegionCode = null;
            IsOnlyStateProvinceFlag = false;
            Name = null;
            TerritoryID = 0;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            Addresses = new HashSet<Address>();
            SalesTaxRates = new HashSet<SalesTaxRate>();

        }

        [Key]
        [Column("StateProvinceID", Order = 0, TypeName = "int")]
        public int StateProvinceID { get; set; }

        [Required]
        [Column("StateProvinceCode", Order = 1, TypeName = "nchar")]
        [StringLength(3)]
        public string StateProvinceCode { get; set; }

        [Required]
        [StringLength(3)]
        public string CountryRegionCode { get; set; }

        [Column("IsOnlyStateProvinceFlag", Order = 3, TypeName = "bit")]
        public bool IsOnlyStateProvinceFlag { get; set; }

        [Required]
        [Column("Name", Order = 4, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        public int TerritoryID { get; set; }

        [Column("rowguid", Order = 6, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 7, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//Address StateProvince
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Address> Addresses { get; set; }

//SalesTaxRate StateProvince
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesTaxRate> SalesTaxRates { get; set; }

        public virtual CountryRegion CountryRegion { get; set; }

        public virtual SalesTerritory SalesTerritory { get; set; }

    }
}
