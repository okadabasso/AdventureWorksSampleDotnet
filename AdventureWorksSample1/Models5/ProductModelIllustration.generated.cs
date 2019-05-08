using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Production.ProductModelIllustration")]
    public partial class ProductModelIllustration
    {
        public ProductModelIllustration()
        {
            ProductModelId = 0;
            IllustrationId = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Primary key. Foreign key to ProductModel.ProductModelID.</summary>
        [Key]
        [Column("ProductModelID", Order = 0, TypeName = "int")]
        public int ProductModelId { get; set; }

        ///<summary>Primary key. Foreign key to Illustration.IllustrationID.</summary>
        [Key]
        [Column("IllustrationID", Order = 1, TypeName = "int")]
        public int IllustrationId { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 2, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Illustration Illustration { get; set; }

        public virtual ProductModel ProductModel { get; set; }

    }
}
