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
        [Key]
        [Column("SpecialOfferID", Order = 1, TypeName = "int")]
        public int SpecialOfferId { get; set; }
        [Key]
        [Column("ProductID", Order = 2, TypeName = "int")]
        public int ProductId { get; set; }
        [Column("rowguid", Order = 3, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }
        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public SpecialOfferProduct()
        {
            SpecialOfferId = 0;
            ProductId = 0;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
