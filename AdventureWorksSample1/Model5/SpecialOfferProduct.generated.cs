using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.SpecialOfferProduct")]
    public partial class SpecialOfferProduct
    {
        public SpecialOfferProduct()
        {
            SpecialOfferID = 0;
            ProductID = 0;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            SalesOrderDetails = new HashSet<SalesOrderDetail>();

        }

        [Key]
        [Column("SpecialOfferID", Order = 0, TypeName = "int")]
        public int SpecialOfferID { get; set; }

        [Key]
        [Column("ProductID", Order = 1, TypeName = "int")]
        public int ProductID { get; set; }

        [Column("rowguid", Order = 2, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//SalesOrderDetail SpecialOfferProduct
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }

        public virtual Product Product { get; set; }

        public virtual SpecialOffer SpecialOffer { get; set; }

    }
}
