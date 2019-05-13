using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("ProductModelProductDescriptionCulture", Schema="Production")]
    public partial class ProductModelProductDescriptionCulture
    {
        public ProductModelProductDescriptionCulture()
        {

        }

        ///<summary>Primary key. Foreign key to ProductModel.ProductModelID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ProductModelID", Order = 0)]
        public int ProductModelId { get; set; }

        ///<summary>Primary key. Foreign key to ProductDescription.ProductDescriptionID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ProductDescriptionID", Order = 1)]
        public int ProductDescriptionId { get; set; }

        ///<summary>Culture identification number. Foreign key to Culture.CultureID.</summary>
        ///<remarks></remarks>
        [Key]
        [Required]
        [Column("CultureID", Order = 2)]
        [StringLength(6)]
        public string CultureId { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 3)]
        public DateTime ModifiedDate { get; set; }

        public virtual Culture Culture { get; set; }

        public virtual ProductDescription ProductDescription { get; set; }

        public virtual ProductModel ProductModel { get; set; }

    }
}
