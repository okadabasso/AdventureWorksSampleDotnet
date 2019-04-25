using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.SalesPersonQuotaHistory")]
    public partial class SalesPersonQuotaHistory
    {
        [Key]
        [Column("BusinessEntityID", Order = 1, TypeName = "int")]
        public int BusinessEntityId { get; set; }
        [Key]
        [Column("QuotaDate", Order = 2, TypeName = "datetime")]
        public DateTime QuotaDate { get; set; }
        [Column("SalesQuota", Order = 3, TypeName = "money")]
        public decimal SalesQuota { get; set; }
        [Column("rowguid", Order = 4, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }
        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public SalesPersonQuotaHistory()
        {
            BusinessEntityId = 0;
            QuotaDate = DateTime.Parse("0001/01/01 0:00:00");
            SalesQuota = 0;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
