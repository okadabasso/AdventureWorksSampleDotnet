using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("SalesPersonQuotaHistory", Schema="Sales")]
    public partial class SalesPersonQuotaHistory
    {
        public SalesPersonQuotaHistory()
        {

        }

        ///<summary>Sales person identification number. Foreign key to SalesPerson.BusinessEntityID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("BusinessEntityID", Order = 0)]
        public int BusinessEntityId { get; set; }

        ///<summary>Sales quota date.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("QuotaDate", Order = 1)]
        public DateTime QuotaDate { get; set; }

        ///<summary>Sales quota amount.</summary>
        ///<remarks></remarks>
        [Column("SalesQuota", Order = 2)]
        public decimal SalesQuota { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 3)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 4)]
        public DateTime ModifiedDate { get; set; }

        public virtual SalesPerson SalesPerson { get; set; }

    }
}
