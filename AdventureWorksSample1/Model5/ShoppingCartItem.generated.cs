using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.ShoppingCartItem")]
    public partial class ShoppingCartItem
    {
        [Key]
        [Column("ShoppingCartItemID", Order = 1, TypeName = "int")]
        public int ShoppingCartItemId { get; set; }
        [Column("ShoppingCartID", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string ShoppingCartId { get; set; }
        [Column("Quantity", Order = 3, TypeName = "int")]
        public int Quantity { get; set; }
        [Column("ProductID", Order = 4, TypeName = "int")]
        public int ProductId { get; set; }
        [Column("DateCreated", Order = 5, TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [Column("ModifiedDate", Order = 6, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public ShoppingCartItem()
        {
            ShoppingCartItemId = 0;
            ShoppingCartId = null;
            Quantity = 0;
            ProductId = 0;
            DateCreated = DateTime.Parse("0001/01/01 0:00:00");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
