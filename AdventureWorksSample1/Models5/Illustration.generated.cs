using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Production.Illustration")]
    public partial class Illustration
    {
        public Illustration()
        {
            IllustrationId = 0;
            Diagram = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            ProductModelIllustrations = new HashSet<ProductModelIllustration>();

        }

        ///<summary>Primary key for Illustration records.</summary>
        [Key]
        [Column("IllustrationID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IllustrationId { get; set; }

        ///<summary>Illustrations used in manufacturing instructions. Stored as XML.</summary>
        [Column("Diagram", Order = 1, TypeName = "xml")]
        public string Diagram { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 2, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; }

    }
}
