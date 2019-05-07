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
        public SalesPersonQuotaHistory()
        {
            BusinessEntityID = 0;
            QuotaDate = DateTime.Parse("0001/01/01 0:00:00");
            SalesQuota = 0;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityID { get; set; }

        [Key]
        [Column("QuotaDate", Order = 1, TypeName = "datetime")]
        public DateTime QuotaDate { get; set; }

        [Column("SalesQuota", Order = 2, TypeName = "money")]
        public decimal SalesQuota { get; set; }

        [Column("rowguid", Order = 3, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual SalesPerson SalesPerson { get; set; }

    }
}
