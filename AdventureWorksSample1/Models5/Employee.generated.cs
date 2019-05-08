using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("HumanResources.Employee")]
    public partial class Employee
    {
        public Employee()
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
            SalariedFlag = false;
            VacationHours = 0;
            SickLeaveHours = 0;
            CurrentFlag = false;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
            EmployeePayHistories = new HashSet<EmployeePayHistory>();
            JobCandidates = new HashSet<JobCandidate>();
            PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();

        }

        ///<summary>Primary key for Employee records.  Foreign key to BusinessEntity.BusinessEntityID.</summary>
        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityId { get; set; }

        ///<summary>Unique national identification number such as a social security number.</summary>
        [Required]
        [Column("NationalIDNumber", Order = 1, TypeName = "nvarchar")]
        [StringLength(15)]
        public string NationalIdNumber { get; set; }

        ///<summary>Network login.</summary>
        [Required]
        [Column("LoginID", Order = 2, TypeName = "nvarchar")]
        [StringLength(256)]
        public string LoginId { get; set; }

        ///<summary>The depth of the employee in the corporate hierarchy.</summary>
        [Column("OrganizationLevel", Order = 4, TypeName = "smallint")]
        public short? OrganizationLevel { get; set; }

        ///<summary>Work title such as Buyer or Sales Representative.</summary>
        [Required]
        [Column("JobTitle", Order = 5, TypeName = "nvarchar")]
        [StringLength(50)]
        public string JobTitle { get; set; }

        ///<summary>Date of birth.</summary>
        [Column("BirthDate", Order = 6, TypeName = "date")]
        public DateTime BirthDate { get; set; }

        ///<summary>M = Married, S = Single</summary>
        [Required]
        [Column("MaritalStatus", Order = 7, TypeName = "nchar")]
        [StringLength(1)]
        public string MaritalStatus { get; set; }

        ///<summary>M = Male, F = Female</summary>
        [Required]
        [Column("Gender", Order = 8, TypeName = "nchar")]
        [StringLength(1)]
        public string Gender { get; set; }

        ///<summary>Employee hired on this date.</summary>
        [Column("HireDate", Order = 9, TypeName = "date")]
        public DateTime HireDate { get; set; }

        ///<summary>Job classification. 0 = Hourly, not exempt from collective bargaining. 1 = Salaried, exempt from collective bargaining.</summary>
        [Column("SalariedFlag", Order = 10, TypeName = "bit")]
        public bool SalariedFlag { get; set; }

        ///<summary>Number of available vacation hours.</summary>
        [Column("VacationHours", Order = 11, TypeName = "smallint")]
        public short VacationHours { get; set; }

        ///<summary>Number of available sick leave hours.</summary>
        [Column("SickLeaveHours", Order = 12, TypeName = "smallint")]
        public short SickLeaveHours { get; set; }

        ///<summary>0 = Inactive, 1 = Active</summary>
        [Column("CurrentFlag", Order = 13, TypeName = "bit")]
        public bool CurrentFlag { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 14, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 15, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeePayHistory> EmployeePayHistories { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobCandidate> JobCandidates { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

        public virtual SalesPerson SalesPerson { get; set; }

        public virtual Person Person { get; set; }

    }
}
