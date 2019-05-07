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
        public SalesReason()
        {
            SalesReasonID = 0;
            Name = null;
            ReasonType = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            SalesOrderHeaderSalesReasons = new HashSet<SalesOrderHeaderSalesReason>();

        }

        [Key]
        [Column("SalesReasonID", Order = 0, TypeName = "int")]
        public int SalesReasonID { get; set; }

        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Column("ReasonType", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string ReasonType { get; set; }

        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//SalesOrderHeaderSalesReason SalesReason
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }

    }
}
