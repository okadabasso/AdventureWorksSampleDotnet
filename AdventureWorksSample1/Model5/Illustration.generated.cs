using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.Illustration")]
    public partial class Illustration
    {
        public Illustration()
        {
            IllustrationID = 0;
            Diagram = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            ProductModelIllustrations = new HashSet<ProductModelIllustration>();

        }

        [Key]
        [Column("IllustrationID", Order = 0, TypeName = "int")]
        public int IllustrationID { get; set; }

        [Column("Diagram", Order = 1, TypeName = "xml")]
        public string Diagram { get; set; }

        [Column("ModifiedDate", Order = 2, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//ProductModelIllustration Illustration
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; }

    }
}
