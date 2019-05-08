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
            ProductId = 0;
            LocationId = 0;
            Shelf = null;
            Bin = 0;
            Quantity = 0;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Product identification number. Foreign key to Product.ProductID.</summary>
        [Key]
        [Column("ProductID", Order = 0, TypeName = "int")]
        public int ProductId { get; set; }

        ///<summary>Inventory location identification number. Foreign key to Location.LocationID. </summary>
        [Key]
        [Column("LocationID", Order = 1, TypeName = "smallint")]
        public short LocationId { get; set; }

        ///<summary>Storage compartment within an inventory location.</summary>
        [Required]
        [Column("Shelf", Order = 2, TypeName = "nvarchar")]
        [StringLength(10)]
        public string Shelf { get; set; }

        ///<summary>Storage container on a shelf in an inventory location.</summary>
        [Column("Bin", Order = 3, TypeName = "tinyint")]
        public byte Bin { get; set; }

        ///<summary>Quantity of products in the inventory location.</summary>
        [Column("Quantity", Order = 4, TypeName = "smallint")]
        public short Quantity { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 5, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 6, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Location Location { get; set; }

        public virtual Product Product { get; set; }

    }
}
