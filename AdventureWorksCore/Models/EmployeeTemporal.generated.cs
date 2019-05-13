using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("Employee_Temporal", Schema="HumanResources")]
    public partial class EmployeeTemporal
    {
        public EmployeeTemporal()
        {

        }

        ///<summary>column:BusinessEntityID</summary>
        ///<remarks></remarks>
        [Key]
        [Column("BusinessEntityID", Order = 0)]
        public int BusinessEntityId { get; set; }

        ///<summary>column:NationalIDNumber</summary>
        ///<remarks></remarks>
        [Required]
        [Column("NationalIDNumber", Order = 1)]
        [StringLength(15)]
        public string NationalIdNumber { get; set; }

        ///<summary>column:LoginID</summary>
        ///<remarks></remarks>
        [Required]
        [Column("LoginID", Order = 2)]
        [StringLength(256)]
        public string LoginId { get; set; }

        ///<summary>column:OrganizationLevel</summary>
        ///<remarks></remarks>
        [Column("OrganizationLevel", Order = 4)]
        public short? OrganizationLevel { get; set; }

        ///<summary>column:JobTitle</summary>
        ///<remarks></remarks>
        [Required]
        [Column("JobTitle", Order = 5)]
        [StringLength(50)]
        public string JobTitle { get; set; }

        ///<summary>column:BirthDate</summary>
        ///<remarks></remarks>
        [Column("BirthDate", Order = 6)]
        public DateTime BirthDate { get; set; }

        ///<summary>column:MaritalStatus</summary>
        ///<remarks></remarks>
        [Required]
        [Column("MaritalStatus", Order = 7)]
        [StringLength(1)]
        public string MaritalStatus { get; set; }

        ///<summary>column:Gender</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Gender", Order = 8)]
        [StringLength(1)]
        public string Gender { get; set; }

        ///<summary>column:HireDate</summary>
        ///<remarks></remarks>
        [Column("HireDate", Order = 9)]
        public DateTime HireDate { get; set; }

        ///<summary>column:VacationHours</summary>
        ///<remarks></remarks>
        [Column("VacationHours", Order = 10)]
        public short VacationHours { get; set; }

        ///<summary>column:SickLeaveHours</summary>
        ///<remarks></remarks>
        [Column("SickLeaveHours", Order = 11)]
        public short SickLeaveHours { get; set; }

        ///<summary>column:ValidFrom</summary>
        ///<remarks></remarks>
        [Column("ValidFrom", Order = 12)]
        public DateTime ValidFrom { get; set; }

        ///<summary>column:ValidTo</summary>
        ///<remarks></remarks>
        [Column("ValidTo", Order = 13)]
        public DateTime ValidTo { get; set; }

    }
}
