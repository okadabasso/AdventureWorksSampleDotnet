using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("SpecialOfferProduct_ondisk", Schema="Sales")]
    public partial class SpecialOfferProductOndisk
    {
        public SpecialOfferProductOndisk()
        {
            SalesOrderDetailOndisks = new HashSet<SalesOrderDetailOndisk>();

        }

        ///<summary>column:SpecialOfferID</summary>
        ///<remarks></remarks>
        [Key]
        [Column("SpecialOfferID", Order = 0)]
        public int SpecialOfferId { get; set; }

        ///<summary>column:ProductID</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ProductID", Order = 1)]
        public int ProductId { get; set; }

        ///<summary>column:ModifiedDate</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 2)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetailOndisk> SalesOrderDetailOndisks { get; set; }

        public virtual ProductOndisk ProductOndisk { get; set; }

        public virtual SpecialOfferOndisk SpecialOfferOndisk { get; set; }

    }
}
