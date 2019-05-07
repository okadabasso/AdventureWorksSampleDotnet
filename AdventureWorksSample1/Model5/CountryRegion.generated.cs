using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Person.CountryRegion")]
    public partial class CountryRegion
    {
        public CountryRegion()
        {
            CountryRegionCode = null;
            Name = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            StateProvinces = new HashSet<StateProvince>();
            CountryRegionCurrencies = new HashSet<CountryRegionCurrency>();
            SalesTerritories = new HashSet<SalesTerritory>();

        }

        [Key]
        [Required]
        [Column("CountryRegionCode", Order = 0, TypeName = "nvarchar")]
        [StringLength(3)]
        public string CountryRegionCode { get; set; }

        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("ModifiedDate", Order = 2, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//StateProvince CountryRegion
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StateProvince> StateProvinces { get; set; }

//CountryRegionCurrency CountryRegion
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CountryRegionCurrency> CountryRegionCurrencies { get; set; }

//SalesTerritory CountryRegion
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesTerritory> SalesTerritories { get; set; }

    }
}
