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
        [Key]
        [Column("IllustrationID", Order = 1, TypeName = "int")]
        public int IllustrationId { get; set; }
        [Column("Diagram", Order = 2, TypeName = "xml")]
        public object Diagram { get; set; }
        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public Illustration()
        {
            IllustrationId = 0;
            Diagram = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
