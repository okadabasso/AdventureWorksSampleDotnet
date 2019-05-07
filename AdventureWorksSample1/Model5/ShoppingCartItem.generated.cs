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
        public ShoppingCartItem()
        {
            ShoppingCartItemID = 0;
            ShoppingCartID = null;
            Quantity = 0;
            ProductID = 0;
            DateCreated = DateTime.Parse("0001/01/01 0:00:00");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("ShoppingCartItemID", Order = 0, TypeName = "int")]
        public int ShoppingCartItemID { get; set; }

        [Required]
        [Column("ShoppingCartID", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string ShoppingCartID { get; set; }

        [Column("Quantity", Order = 2, TypeName = "int")]
        public int Quantity { get; set; }

        public int ProductID { get; set; }

        [Column("DateCreated", Order = 4, TypeName = "datetime")]
        public DateTime DateCreated { get; set; }

        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

    }
}
