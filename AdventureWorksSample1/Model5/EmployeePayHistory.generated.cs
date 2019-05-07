using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("HumanResources.EmployeePayHistory")]
    public partial class EmployeePayHistory
    {
        public EmployeePayHistory()
        {
            BusinessEntityID = 0;
            RateChangeDate = DateTime.Parse("0001/01/01 0:00:00");
            Rate = 0;
            PayFrequency = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityID { get; set; }

        [Key]
        [Column("RateChangeDate", Order = 1, TypeName = "datetime")]
        public DateTime RateChangeDate { get; set; }

        [Column("Rate", Order = 2, TypeName = "money")]
        public decimal Rate { get; set; }

        [Column("PayFrequency", Order = 3, TypeName = "tinyint")]
        public byte PayFrequency { get; set; }

        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Employee Employee { get; set; }

    }
}
