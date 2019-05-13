using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("Illustration", Schema="Production")]
    public partial class Illustration
    {
        public Illustration()
        {
            ProductModelIllustrations = new HashSet<ProductModelIllustration>();

        }

        ///<summary>Primary key for Illustration records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("IllustrationID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IllustrationId { get; set; }

        ///<summary>Illustrations used in manufacturing instructions. Stored as XML.</summary>
        ///<remarks></remarks>
        [Column("Diagram", Order = 1)]
        public string Diagram { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 2)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; }

    }
}
