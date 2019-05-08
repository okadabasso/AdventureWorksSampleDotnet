using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Sales.SalesPersonQuotaHistory")]
    public partial class SalesPersonQuotaHistory
    {
        public SalesPersonQuotaHistory()
        {
            BusinessEntityId = 0;
            QuotaDate = DateTime.Parse("0001/01/01 0:00:00");
            SalesQuota = 0;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Sales person identification number. Foreign key to SalesPerson.BusinessEntityID.</summary>
        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityId { get; set; }

        ///<summary>Sales quota date.</summary>
        [Key]
        [Column("QuotaDate", Order = 1, TypeName = "datetime")]
        public DateTime QuotaDate { get; set; }

        ///<summary>Sales quota amount.</summary>
        [Column("SalesQuota", Order = 2, TypeName = "money")]
        public decimal SalesQuota { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 3, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual SalesPerson SalesPerson { get; set; }

    }
}
