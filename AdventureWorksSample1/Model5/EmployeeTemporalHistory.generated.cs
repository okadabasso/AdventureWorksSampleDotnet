using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("HumanResources.Employee_Temporal_History")]
    public partial class EmployeeTemporalHistory
    {
        public EmployeeTemporalHistory()
        {
            BusinessEntityId = 0;
            NationalIdNumber = null;
            LoginId = null;
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

        ///<summary>column:BusinessEntityID</summary>
        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityId { get; set; }

        ///<summary>column:NationalIDNumber</summary>
        [Required]
        [Column("NationalIDNumber", Order = 1, TypeName = "nvarchar")]
        [StringLength(15)]
        public string NationalIdNumber { get; set; }

        ///<summary>column:LoginID</summary>
        [Required]
        [Column("LoginID", Order = 2, TypeName = "nvarchar")]
        [StringLength(256)]
        public string LoginId { get; set; }

        ///<summary>column:OrganizationLevel</summary>
        [Column("OrganizationLevel", Order = 4, TypeName = "smallint")]
        public short? OrganizationLevel { get; set; }

        ///<summary>column:JobTitle</summary>
        [Required]
        [Column("JobTitle", Order = 5, TypeName = "nvarchar")]
        [StringLength(50)]
        public string JobTitle { get; set; }

        ///<summary>column:BirthDate</summary>
        [Column("BirthDate", Order = 6, TypeName = "date")]
        public DateTime BirthDate { get; set; }

        ///<summary>column:MaritalStatus</summary>
        [Required]
        [Column("MaritalStatus", Order = 7, TypeName = "nchar")]
        [StringLength(1)]
        public string MaritalStatus { get; set; }

        ///<summary>column:Gender</summary>
        [Required]
        [Column("Gender", Order = 8, TypeName = "nchar")]
        [StringLength(1)]
        public string Gender { get; set; }

        ///<summary>column:HireDate</summary>
        [Column("HireDate", Order = 9, TypeName = "date")]
        public DateTime HireDate { get; set; }

        ///<summary>column:VacationHours</summary>
        [Column("VacationHours", Order = 10, TypeName = "smallint")]
        public short VacationHours { get; set; }

        ///<summary>column:SickLeaveHours</summary>
        [Column("SickLeaveHours", Order = 11, TypeName = "smallint")]
        public short SickLeaveHours { get; set; }

        ///<summary>column:ValidFrom</summary>
        [Column("ValidFrom", Order = 12, TypeName = "datetime2")]
        public DateTime ValidFrom { get; set; }

        ///<summary>column:ValidTo</summary>
        [Column("ValidTo", Order = 13, TypeName = "datetime2")]
        public DateTime ValidTo { get; set; }

    }
}
