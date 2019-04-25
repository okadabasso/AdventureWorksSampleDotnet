using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.CurrencyRate")]
    public partial class CurrencyRate
    {
        [Key]
        [Column("CurrencyRateID", Order = 1, TypeName = "int")]
        public int CurrencyRateId { get; set; }
        [Column("CurrencyRateDate", Order = 2, TypeName = "datetime")]
        public DateTime CurrencyRateDate { get; set; }
        [Column("FromCurrencyCode", Order = 3, TypeName = "nchar")]
        [StringLength(3)]
        public string FromCurrencyCode { get; set; }
        [Column("ToCurrencyCode", Order = 4, TypeName = "nchar")]
        [StringLength(3)]
        public string ToCurrencyCode { get; set; }
        [Column("AverageRate", Order = 5, TypeName = "money")]
        public decimal AverageRate { get; set; }
        [Column("EndOfDayRate", Order = 6, TypeName = "money")]
        public decimal EndOfDayRate { get; set; }
        [Column("ModifiedDate", Order = 7, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public CurrencyRate()
        {
            CurrencyRateId = 0;
            CurrencyRateDate = DateTime.Parse("0001/01/01 0:00:00");
            FromCurrencyCode = null;
            ToCurrencyCode = null;
            AverageRate = 0;
            EndOfDayRate = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
