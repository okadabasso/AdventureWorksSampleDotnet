using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("ProductSubcategory", Schema="Production")]
    public partial class ProductSubcategory
    {
        public ProductSubcategory()
        {
            Products = new HashSet<Product>();

        }

        ///<summary>Primary key for ProductSubcategory records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ProductSubcategoryID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductSubcategoryId { get; set; }

        ///<summary>Product category identification number. Foreign key to ProductCategory.ProductCategoryID.</summary>
        ///<remarks></remarks>
        [Column("ProductCategoryID")]
        public int ProductCategoryId { get; set; }

        ///<summary>Subcategory description.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Name", Order = 2)]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 3)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 4)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }

    }
}
