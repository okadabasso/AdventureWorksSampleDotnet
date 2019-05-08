using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.SpecialOfferProduct_inmem")]
    public partial class SpecialOfferProduct_inmem
    {
        public SpecialOfferProduct_inmem()
        {
            SpecialOfferID = 0;
            ProductID = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            SalesOrderDetail_inmems = new HashSet<SalesOrderDetail_inmem>();

        }

        [Key]
        [Column("SpecialOfferID", Order = 0, TypeName = "int")]
        public int SpecialOfferID { get; set; }

        [Key]
        [Column("ProductID", Order = 1, TypeName = "int")]
        public int ProductID { get; set; }

        [Column("ModifiedDate", Order = 2, TypeName = "datetime2")]
        public DateTime ModifiedDate { get; set; }

//SalesOrderDetail_inmem SpecialOfferProduct_inmem
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetail_inmem> SalesOrderDetail_inmems { get; set; }

        public virtual Product_inmem Product_inmem { get; set; }

        public virtual SpecialOffer_inmem SpecialOffer_inmem { get; set; }

    }
}
