using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Sales.SalesReason")]
    public partial class SalesReason
    {
        public SalesReason()
        {
            SalesReasonId = 0;
            Name = null;
            ReasonType = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            SalesOrderHeaderSalesReasons = new HashSet<SalesOrderHeaderSalesReason>();

        }

        ///<summary>Primary key for SalesReason records.</summary>
        [Key]
        [Column("SalesReasonID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesReasonId { get; set; }

        ///<summary>Sales reason description.</summary>
        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>Category the sales reason belongs to.</summary>
        [Required]
        [Column("ReasonType", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string ReasonType { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }

    }
}
