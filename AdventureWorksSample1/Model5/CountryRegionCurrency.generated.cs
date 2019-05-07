using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.CountryRegionCurrency")]
    public partial class CountryRegionCurrency
    {
        public CountryRegionCurrency()
        {
            CountryRegionCode = null;
            CurrencyCode = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Required]
        [Column("CountryRegionCode", Order = 0, TypeName = "nvarchar")]
        [StringLength(3)]
        public string CountryRegionCode { get; set; }

        [Key]
        [Required]
        [Column("CurrencyCode", Order = 1, TypeName = "nchar")]
        [StringLength(3)]
        public string CurrencyCode { get; set; }

        [Column("ModifiedDate", Order = 2, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual CountryRegion CountryRegion { get; set; }

        public virtual Currency Currency { get; set; }

    }
}
