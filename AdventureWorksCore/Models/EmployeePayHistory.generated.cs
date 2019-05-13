using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("EmployeePayHistory", Schema="HumanResources")]
    public partial class EmployeePayHistory
    {
        public EmployeePayHistory()
        {

        }

        ///<summary>Employee identification number. Foreign key to Employee.BusinessEntityID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("BusinessEntityID", Order = 0)]
        public int BusinessEntityId { get; set; }

        ///<summary>Date the change in pay is effective</summary>
        ///<remarks></remarks>
        [Key]
        [Column("RateChangeDate", Order = 1)]
        public DateTime RateChangeDate { get; set; }

        ///<summary>Salary hourly rate.</summary>
        ///<remarks></remarks>
        [Column("Rate", Order = 2)]
        public decimal Rate { get; set; }

        ///<summary>1 = Salary received monthly, 2 = Salary received biweekly</summary>
        ///<remarks></remarks>
        [Column("PayFrequency", Order = 3)]
        public byte PayFrequency { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 4)]
        public DateTime ModifiedDate { get; set; }

        public virtual Employee Employee { get; set; }

    }
}
