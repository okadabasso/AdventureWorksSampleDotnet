using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Sales.ShoppingCartItem")]
    public partial class ShoppingCartItem
    {
        public ShoppingCartItem()
        {
            ShoppingCartItemId = 0;
            ShoppingCartId = null;
            Quantity = 0;
            ProductId = 0;
            DateCreated = DateTime.Parse("0001/01/01 0:00:00");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Primary key for ShoppingCartItem records.</summary>
        [Key]
        [Column("ShoppingCartItemID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShoppingCartItemId { get; set; }

        ///<summary>Shopping cart identification number.</summary>
        [Required]
        [Column("ShoppingCartID", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string ShoppingCartId { get; set; }

        ///<summary>Product quantity ordered.</summary>
        [Column("Quantity", Order = 2, TypeName = "int")]
        public int Quantity { get; set; }

        ///<summary>Product ordered. Foreign key to Product.ProductID.</summary>
        [Column("ProductID")]
        public int ProductId { get; set; }

        ///<summary>Date the time the record was created.</summary>
        [Column("DateCreated", Order = 4, TypeName = "datetime")]
        public DateTime DateCreated { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

    }
}
