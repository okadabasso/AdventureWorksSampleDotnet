using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Sales.SpecialOfferProduct_ondisk")]
    public partial class SpecialOfferProductOndisk
    {
        public SpecialOfferProductOndisk()
        {
            SpecialOfferId = 0;
            ProductId = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            SalesOrderDetailOndisks = new HashSet<SalesOrderDetailOndisk>();

        }

        ///<summary>column:SpecialOfferID</summary>
        [Key]
        [Column("SpecialOfferID", Order = 0, TypeName = "int")]
        public int SpecialOfferId { get; set; }

        ///<summary>column:ProductID</summary>
        [Key]
        [Column("ProductID", Order = 1, TypeName = "int")]
        public int ProductId { get; set; }

        ///<summary>column:ModifiedDate</summary>
        [Column("ModifiedDate", Order = 2, TypeName = "datetime2")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetailOndisk> SalesOrderDetailOndisks { get; set; }

        public virtual ProductOndisk ProductOndisk { get; set; }

        public virtual SpecialOfferOndisk SpecialOfferOndisk { get; set; }

    }
}
