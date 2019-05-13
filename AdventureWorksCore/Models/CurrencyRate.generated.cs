using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("CurrencyRate", Schema="Sales")]
    public partial class CurrencyRate
    {
        public CurrencyRate()
        {
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();

        }

        ///<summary>Primary key for CurrencyRate records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("CurrencyRateID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CurrencyRateId { get; set; }

        ///<summary>Date and time the exchange rate was obtained.</summary>
        ///<remarks></remarks>
        [Column("CurrencyRateDate", Order = 1)]
        public DateTime CurrencyRateDate { get; set; }

        ///<summary>Exchange rate was converted from this currency code.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("FromCurrencyCode")]
        [StringLength(3)]
        public string FromCurrencyCode { get; set; }

        ///<summary>Exchange rate was converted to this currency code.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("ToCurrencyCode")]
        [StringLength(3)]
        public string ToCurrencyCode { get; set; }

        ///<summary>Average exchange rate for the day.</summary>
        ///<remarks></remarks>
        [Column("AverageRate", Order = 4)]
        public decimal AverageRate { get; set; }

        ///<summary>Final exchange rate for the day.</summary>
        ///<remarks></remarks>
        [Column("EndOfDayRate", Order = 5)]
        public decimal EndOfDayRate { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 6)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        public virtual Currency FromCurrency { get; set; }

        public virtual Currency ToCurrency { get; set; }

    }
}
