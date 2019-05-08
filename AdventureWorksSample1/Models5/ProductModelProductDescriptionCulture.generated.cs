using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Production.ProductModelProductDescriptionCulture")]
    public partial class ProductModelProductDescriptionCulture
    {
        public ProductModelProductDescriptionCulture()
        {
            ProductModelId = 0;
            ProductDescriptionId = 0;
            CultureId = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Primary key. Foreign key to ProductModel.ProductModelID.</summary>
        [Key]
        [Column("ProductModelID", Order = 0, TypeName = "int")]
        public int ProductModelId { get; set; }

        ///<summary>Primary key. Foreign key to ProductDescription.ProductDescriptionID.</summary>
        [Key]
        [Column("ProductDescriptionID", Order = 1, TypeName = "int")]
        public int ProductDescriptionId { get; set; }

        ///<summary>Culture identification number. Foreign key to Culture.CultureID.</summary>
        [Key]
        [Required]
        [Column("CultureID", Order = 2, TypeName = "nchar")]
        [StringLength(6)]
        public string CultureId { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Culture Culture { get; set; }

        public virtual ProductDescription ProductDescription { get; set; }

        public virtual ProductModel ProductModel { get; set; }

    }
}
