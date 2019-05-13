using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("CountryRegion", Schema="Person")]
    public partial class CountryRegion
    {
        public CountryRegion()
        {
            StateProvinces = new HashSet<StateProvince>();
            CountryRegionCurrencies = new HashSet<CountryRegionCurrency>();
            SalesTerritories = new HashSet<SalesTerritory>();

        }

        ///<summary>ISO standard code for countries and regions.</summary>
        ///<remarks></remarks>
        [Key]
        [Required]
        [Column("CountryRegionCode", Order = 0)]
        [StringLength(3)]
        public string CountryRegionCode { get; set; }

        ///<summary>Country or region name.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Name", Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 2)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StateProvince> StateProvinces { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CountryRegionCurrency> CountryRegionCurrencies { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesTerritory> SalesTerritories { get; set; }

    }
}
