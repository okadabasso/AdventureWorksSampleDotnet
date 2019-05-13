using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("CountryRegionCurrency", Schema="Sales")]
    public partial class CountryRegionCurrency
    {
        public CountryRegionCurrency()
        {

        }

        ///<summary>ISO code for countries and regions. Foreign key to CountryRegion.CountryRegionCode.</summary>
        ///<remarks></remarks>
        [Key]
        [Required]
        [Column("CountryRegionCode", Order = 0)]
        [StringLength(3)]
        public string CountryRegionCode { get; set; }

        ///<summary>ISO standard currency code. Foreign key to Currency.CurrencyCode.</summary>
        ///<remarks></remarks>
        [Key]
        [Required]
        [Column("CurrencyCode", Order = 1)]
        [StringLength(3)]
        public string CurrencyCode { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 2)]
        public DateTime ModifiedDate { get; set; }

        public virtual CountryRegion CountryRegion { get; set; }

        public virtual Currency Currency { get; set; }

    }
}
