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
        public ProductInventory()
        {
            ProductID = 0;
            LocationID = 0;
            Shelf = null;
            Bin = 0;
            Quantity = 0;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("ProductID", Order = 0, TypeName = "int")]
        public int ProductID { get; set; }

        [Key]
        [Column("LocationID", Order = 1, TypeName = "smallint")]
        public short LocationID { get; set; }

        [Required]
        [Column("Shelf", Order = 2, TypeName = "nvarchar")]
        [StringLength(10)]
        public string Shelf { get; set; }

        [Column("Bin", Order = 3, TypeName = "tinyint")]
        public byte Bin { get; set; }

        [Column("Quantity", Order = 4, TypeName = "smallint")]
        public short Quantity { get; set; }

        [Column("rowguid", Order = 5, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 6, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Location Location { get; set; }

        public virtual Product Product { get; set; }

    }
}
