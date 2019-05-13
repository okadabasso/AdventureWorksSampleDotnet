using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("Employee", Schema="HumanResources")]
    public partial class Employee
    {
        public Employee()
        {
            EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
            EmployeePayHistories = new HashSet<EmployeePayHistory>();
            JobCandidates = new HashSet<JobCandidate>();
            PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();

        }

        ///<summary>Primary key for Employee records.  Foreign key to BusinessEntity.BusinessEntityID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("BusinessEntityID", Order = 0)]
        public int BusinessEntityId { get; set; }

        ///<summary>Unique national identification number such as a social security number.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("NationalIDNumber", Order = 1)]
        [StringLength(15)]
        public string NationalIdNumber { get; set; }

        ///<summary>Network login.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("LoginID", Order = 2)]
        [StringLength(256)]
        public string LoginId { get; set; }

        ///<summary>The depth of the employee in the corporate hierarchy.</summary>
        ///<remarks></remarks>
        [Column("OrganizationLevel", Order = 4)]
        public short? OrganizationLevel { get; set; }

        ///<summary>Work title such as Buyer or Sales Representative.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("JobTitle", Order = 5)]
        [StringLength(50)]
        public string JobTitle { get; set; }

        ///<summary>Date of birth.</summary>
        ///<remarks></remarks>
        [Column("BirthDate", Order = 6)]
        public DateTime BirthDate { get; set; }

        ///<summary>M = Married, S = Single</summary>
        ///<remarks></remarks>
        [Required]
        [Column("MaritalStatus", Order = 7)]
        [StringLength(1)]
        public string MaritalStatus { get; set; }

        ///<summary>M = Male, F = Female</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Gender", Order = 8)]
        [StringLength(1)]
        public string Gender { get; set; }

        ///<summary>Employee hired on this date.</summary>
        ///<remarks></remarks>
        [Column("HireDate", Order = 9)]
        public DateTime HireDate { get; set; }

        ///<summary>Job classification. 0 = Hourly, not exempt from collective bargaining. 1 = Salaried, exempt from collective bargaining.</summary>
        ///<remarks></remarks>
        [Column("SalariedFlag", Order = 10)]
        public bool SalariedFlag { get; set; }

        ///<summary>Number of available vacation hours.</summary>
        ///<remarks></remarks>
        [Column("VacationHours", Order = 11)]
        public short VacationHours { get; set; }

        ///<summary>Number of available sick leave hours.</summary>
        ///<remarks></remarks>
        [Column("SickLeaveHours", Order = 12)]
        public short SickLeaveHours { get; set; }

        ///<summary>0 = Inactive, 1 = Active</summary>
        ///<remarks></remarks>
        [Column("CurrentFlag", Order = 13)]
        public bool CurrentFlag { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 14)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 15)]
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
