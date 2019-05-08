using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("HumanResources.Employee_Temporal_History")]
    public partial class Employee_Temporal_History
    {
        public Employee_Temporal_History()
        {
            BusinessEntityID = 0;
            NationalIDNumber = null;
            LoginID = null;
            OrganizationLevel = null;
            JobTitle = null;
            BirthDate = DateTime.Parse("0001/01/01 0:00:00");
            MaritalStatus = null;
            Gender = null;
            HireDate = DateTime.Parse("0001/01/01 0:00:00");
            VacationHours = 0;
            SickLeaveHours = 0;
            ValidFrom = DateTime.Parse("0001/01/01 0:00:00");
            ValidTo = DateTime.Parse("0001/01/01 0:00:00");

        }

        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityID { get; set; }

        [Required]
        [Column("NationalIDNumber", Order = 1, TypeName = "nvarchar")]
        [StringLength(15)]
        public string NationalIDNumber { get; set; }

        [Required]
        [Column("LoginID", Order = 2, TypeName = "nvarchar")]
        [StringLength(256)]
        public string LoginID { get; set; }

        [Column("OrganizationLevel", Order = 4, TypeName = "smallint")]
        public short? OrganizationLevel { get; set; }

        [Required]
        [Column("JobTitle", Order = 5, TypeName = "nvarchar")]
        [StringLength(50)]
        public string JobTitle { get; set; }

        [Column("BirthDate", Order = 6, TypeName = "date")]
        public DateTime BirthDate { get; set; }

        [Required]
        [Column("MaritalStatus", Order = 7, TypeName = "nchar")]
        [StringLength(1)]
        public string MaritalStatus { get; set; }

        [Required]
        [Column("Gender", Order = 8, TypeName = "nchar")]
        [StringLength(1)]
        public string Gender { get; set; }

        [Column("HireDate", Order = 9, TypeName = "date")]
        public DateTime HireDate { get; set; }

        [Column("VacationHours", Order = 10, TypeName = "smallint")]
        public short VacationHours { get; set; }

        [Column("SickLeaveHours", Order = 11, TypeName = "smallint")]
        public short SickLeaveHours { get; set; }

        [Column("ValidFrom", Order = 12, TypeName = "datetime2")]
        public DateTime ValidFrom { get; set; }

        [Column("ValidTo", Order = 13, TypeName = "datetime2")]
        public DateTime ValidTo { get; set; }

    }
}
