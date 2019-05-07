using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.ProductModelIllustration")]
    public partial class ProductModelIllustration
    {
        public ProductModelIllustration()
        {
            ProductModelID = 0;
            IllustrationID = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("ProductModelID", Order = 0, TypeName = "int")]
        public int ProductModelID { get; set; }

        [Key]
        [Column("IllustrationID", Order = 1, TypeName = "int")]
        public int IllustrationID { get; set; }

        [Column("ModifiedDate", Order = 2, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Illustration Illustration { get; set; }

        public virtual ProductModel ProductModel { get; set; }

    }
}
