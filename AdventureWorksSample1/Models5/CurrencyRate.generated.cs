using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Sales.CurrencyRate")]
    public partial class CurrencyRate
    {
        public CurrencyRate()
        {
            CurrencyRateId = 0;
            CurrencyRateDate = DateTime.Parse("0001/01/01 0:00:00");
            FromCurrencyCode = null;
            ToCurrencyCode = null;
            AverageRate = 0;
            EndOfDayRate = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();

        }

        ///<summary>Primary key for CurrencyRate records.</summary>
        [Key]
        [Column("CurrencyRateID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CurrencyRateId { get; set; }

        ///<summary>Date and time the exchange rate was obtained.</summary>
        [Column("CurrencyRateDate", Order = 1, TypeName = "datetime")]
        public DateTime CurrencyRateDate { get; set; }

        ///<summary>Exchange rate was converted from this currency code.</summary>
        [Required]
        [Column("FromCurrencyCode")]
        [StringLength(3)]
        public string FromCurrencyCode { get; set; }

        ///<summary>Exchange rate was converted to this currency code.</summary>
        [Required]
        [Column("ToCurrencyCode")]
        [StringLength(3)]
        public string ToCurrencyCode { get; set; }

        ///<summary>Average exchange rate for the day.</summary>
        [Column("AverageRate", Order = 4, TypeName = "money")]
        public decimal AverageRate { get; set; }

        ///<summary>Final exchange rate for the day.</summary>
        [Column("EndOfDayRate", Order = 5, TypeName = "money")]
        public decimal EndOfDayRate { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 6, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        public virtual Currency FromCurrency { get; set; }

        public virtual Currency ToCurrency { get; set; }

    }
}
