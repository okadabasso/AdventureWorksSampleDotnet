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
        public CurrencyRate()
        {
            CurrencyRateID = 0;
            CurrencyRateDate = DateTime.Parse("0001/01/01 0:00:00");
            FromCurrencyCode = null;
            ToCurrencyCode = null;
            AverageRate = 0;
            EndOfDayRate = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            SalesOrderHeaders = new HashSet<SalesOrderHeader>();

        }

        [Key]
        [Column("CurrencyRateID", Order = 0, TypeName = "int")]
        public int CurrencyRateID { get; set; }

        [Column("CurrencyRateDate", Order = 1, TypeName = "datetime")]
        public DateTime CurrencyRateDate { get; set; }

        [Required]
        [StringLength(3)]
        public string FromCurrencyCode { get; set; }

        [Required]
        [StringLength(3)]
        public string ToCurrencyCode { get; set; }

        [Column("AverageRate", Order = 4, TypeName = "money")]
        public decimal AverageRate { get; set; }

        [Column("EndOfDayRate", Order = 5, TypeName = "money")]
        public decimal EndOfDayRate { get; set; }

        [Column("ModifiedDate", Order = 6, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//SalesOrderHeader CurrencyRate
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        public virtual Currency Currency { get; set; }

        public virtual Currency Currency1 { get; set; }

    }
}
