using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("ShoppingCartItem", Schema="Sales")]
    public partial class ShoppingCartItem
    {
        public ShoppingCartItem()
        {

        }

        ///<summary>Primary key for ShoppingCartItem records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ShoppingCartItemID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShoppingCartItemId { get; set; }

        ///<summary>Shopping cart identification number.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("ShoppingCartID", Order = 1)]
        [StringLength(50)]
        public string ShoppingCartId { get; set; }

        ///<summary>Product quantity ordered.</summary>
        ///<remarks></remarks>
        [Column("Quantity", Order = 2)]
        public int Quantity { get; set; }

        ///<summary>Product ordered. Foreign key to Product.ProductID.</summary>
        ///<remarks></remarks>
        [Column("ProductID")]
        public int ProductId { get; set; }

        ///<summary>Date the time the record was created.</summary>
        ///<remarks></remarks>
        [Column("DateCreated", Order = 4)]
        public DateTime DateCreated { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 5)]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

    }
}
