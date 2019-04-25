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
        [Key]
        [Column("CountryRegionCode", Order = 1, TypeName = "nvarchar")]
        [StringLength(3)]
        public string CountryRegionCode { get; set; }
        [Key]
        [Column("CurrencyCode", Order = 2, TypeName = "nchar")]
        [StringLength(3)]
        public string CurrencyCode { get; set; }
        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public CountryRegionCurrency()
        {
            CountryRegionCode = null;
            CurrencyCode = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
