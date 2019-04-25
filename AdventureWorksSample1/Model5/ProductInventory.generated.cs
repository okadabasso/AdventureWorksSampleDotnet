using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.ProductInventory")]
    public partial class ProductInventory
    {
        [Key]
        [Column("ProductID", Order = 1, TypeName = "int")]
        public int ProductId { get; set; }
        [Key]
        [Column("LocationID", Order = 2, TypeName = "smallint")]
        public short LocationId { get; set; }
        [Column("Shelf", Order = 3, TypeName = "nvarchar")]
        [StringLength(10)]
        public string Shelf { get; set; }
        [Column("Bin", Order = 4, TypeName = "tinyint")]
        public byte Bin { get; set; }
        [Column("Quantity", Order = 5, TypeName = "smallint")]
        public short Quantity { get; set; }
        [Column("rowguid", Order = 6, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }
        [Column("ModifiedDate", Order = 7, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public ProductInventory()
        {
            ProductId = 0;
            LocationId = 0;
            Shelf = null;
            Bin = 0;
            Quantity = 0;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
