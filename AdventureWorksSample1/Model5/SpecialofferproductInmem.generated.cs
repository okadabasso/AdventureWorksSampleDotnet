using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.SpecialOfferProduct_inmem")]
    public partial class SpecialofferproductInmem
    {
        [Key]
        [Column("SpecialOfferID", Order = 1, TypeName = "int")]
        public int SpecialOfferId { get; set; }
        [Key]
        [Column("ProductID", Order = 2, TypeName = "int")]
        public int ProductId { get; set; }
        [Column("ModifiedDate", Order = 3, TypeName = "datetime2")]
        public DateTime ModifiedDate { get; set; }
        public SpecialofferproductInmem()
        {
            SpecialOfferId = 0;
            ProductId = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
