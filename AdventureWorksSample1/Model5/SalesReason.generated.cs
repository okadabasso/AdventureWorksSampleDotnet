using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.SalesReason")]
    public partial class SalesReason
    {
        [Key]
        [Column("SalesReasonID", Order = 1, TypeName = "int")]
        public int SalesReasonId { get; set; }
        [Column("Name", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("ReasonType", Order = 3, TypeName = "nvarchar")]
        [StringLength(50)]
        public string ReasonType { get; set; }
        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public SalesReason()
        {
            SalesReasonId = 0;
            Name = null;
            ReasonType = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
