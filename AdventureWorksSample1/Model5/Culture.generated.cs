using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.Culture")]
    public partial class Culture
    {
        public Culture()
        {
            CultureID = null;
            Name = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();

        }

        [Key]
        [Required]
        [Column("CultureID", Order = 0, TypeName = "nchar")]
        [StringLength(6)]
        public string CultureID { get; set; }

        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("ModifiedDate", Order = 2, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//ProductModelProductDescriptionCulture Culture
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }

    }
}
