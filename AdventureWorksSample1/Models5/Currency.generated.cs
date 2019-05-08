using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Sales.Currency")]
    public partial class Currency
    {
        public Currency()
        {
            CurrencyCode = null;
            Name = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            CountryRegionCurrencies = new HashSet<CountryRegionCurrency>();
            CurrencyRates = new HashSet<CurrencyRate>();
            CurrencyRates1 = new HashSet<CurrencyRate>();

        }

        ///<summary>The ISO code for the Currency.</summary>
        [Key]
        [Required]
        [Column("CurrencyCode", Order = 0, TypeName = "nchar")]
        [StringLength(3)]
        public string CurrencyCode { get; set; }

        ///<summary>Currency name.</summary>
        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 2, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CountryRegionCurrency> CountryRegionCurrencies { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CurrencyRate> CurrencyRates { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CurrencyRate> CurrencyRates1 { get; set; }

    }
}
