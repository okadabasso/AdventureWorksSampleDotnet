using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.SpecialOfferProduct_ondisk")]
    public partial class SpecialOfferProduct_ondisk
    {
        public SpecialOfferProduct_ondisk()
        {
            SpecialOfferID = 0;
            ProductID = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            SalesOrderDetail_ondisks = new HashSet<SalesOrderDetail_ondisk>();

        }

        [Key]
        [Column("SpecialOfferID", Order = 0, TypeName = "int")]
        public int SpecialOfferID { get; set; }

        [Key]
        [Column("ProductID", Order = 1, TypeName = "int")]
        public int ProductID { get; set; }

        [Column("ModifiedDate", Order = 2, TypeName = "datetime2")]
        public DateTime ModifiedDate { get; set; }

//SalesOrderDetail_ondisk SpecialOfferProduct_ondisk
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetail_ondisk> SalesOrderDetail_ondisks { get; set; }

        public virtual Product_ondisk Product_ondisk { get; set; }

        public virtual SpecialOffer_ondisk SpecialOffer_ondisk { get; set; }

    }
}
