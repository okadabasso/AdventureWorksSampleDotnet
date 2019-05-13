using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("SalesReason", Schema="Sales")]
    public partial class SalesReason
    {
        public SalesReason()
        {
            SalesOrderHeaderSalesReasons = new HashSet<SalesOrderHeaderSalesReason>();

        }

        ///<summary>Primary key for SalesReason records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("SalesReasonID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesReasonId { get; set; }

        ///<summary>Sales reason description.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Name", Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>Category the sales reason belongs to.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("ReasonType", Order = 2)]
        [StringLength(50)]
        public string ReasonType { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 3)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }

    }
}
