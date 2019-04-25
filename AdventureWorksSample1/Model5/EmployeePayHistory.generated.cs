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
        [Key]
        [Column("BusinessEntityID", Order = 1, TypeName = "int")]
        public int BusinessEntityId { get; set; }
        [Key]
        [Column("RateChangeDate", Order = 2, TypeName = "datetime")]
        public DateTime RateChangeDate { get; set; }
        [Column("Rate", Order = 3, TypeName = "money")]
        public decimal Rate { get; set; }
        [Column("PayFrequency", Order = 4, TypeName = "tinyint")]
        public byte PayFrequency { get; set; }
        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public EmployeePayHistory()
        {
            BusinessEntityId = 0;
            RateChangeDate = DateTime.Parse("0001/01/01 0:00:00");
            Rate = 0;
            PayFrequency = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
