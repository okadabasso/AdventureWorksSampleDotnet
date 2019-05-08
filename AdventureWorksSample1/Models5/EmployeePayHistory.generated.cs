using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("HumanResources.EmployeePayHistory")]
    public partial class EmployeePayHistory
    {
        public EmployeePayHistory()
        {
            BusinessEntityId = 0;
            RateChangeDate = DateTime.Parse("0001/01/01 0:00:00");
            Rate = 0;
            PayFrequency = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Employee identification number. Foreign key to Employee.BusinessEntityID.</summary>
        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityId { get; set; }

        ///<summary>Date the change in pay is effective</summary>
        [Key]
        [Column("RateChangeDate", Order = 1, TypeName = "datetime")]
        public DateTime RateChangeDate { get; set; }

        ///<summary>Salary hourly rate.</summary>
        [Column("Rate", Order = 2, TypeName = "money")]
        public decimal Rate { get; set; }

        ///<summary>1 = Salary received monthly, 2 = Salary received biweekly</summary>
        [Column("PayFrequency", Order = 3, TypeName = "tinyint")]
        public byte PayFrequency { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Employee Employee { get; set; }

    }
}
