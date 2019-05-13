using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("ProductInventory", Schema="Production")]
    public partial class ProductInventory
    {
        public ProductInventory()
        {

        }

        ///<summary>Product identification number. Foreign key to Product.ProductID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ProductID", Order = 0)]
        public int ProductId { get; set; }

        ///<summary>Inventory location identification number. Foreign key to Location.LocationID. </summary>
        ///<remarks></remarks>
        [Key]
        [Column("LocationID", Order = 1)]
        public short LocationId { get; set; }

        ///<summary>Storage compartment within an inventory location.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Shelf", Order = 2)]
        [StringLength(10)]
        public string Shelf { get; set; }

        ///<summary>Storage container on a shelf in an inventory location.</summary>
        ///<remarks></remarks>
        [Column("Bin", Order = 3)]
        public byte Bin { get; set; }

        ///<summary>Quantity of products in the inventory location.</summary>
        ///<remarks></remarks>
        [Column("Quantity", Order = 4)]
        public short Quantity { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 5)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 6)]
        public DateTime ModifiedDate { get; set; }

        public virtual Location Location { get; set; }

        public virtual Product Product { get; set; }

    }
}
