using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("HumanResources.Employee")]
    public partial class Employee
    {
        public Employee()
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
            SalariedFlag = false;
            VacationHours = 0;
            SickLeaveHours = 0;
            CurrentFlag = false;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
            EmployeePayHistories = new HashSet<EmployeePayHistory>();
            JobCandidates = new HashSet<JobCandidate>();
            PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();

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

        [Column("SalariedFlag", Order = 10, TypeName = "bit")]
        public bool SalariedFlag { get; set; }

        [Column("VacationHours", Order = 11, TypeName = "smallint")]
        public short VacationHours { get; set; }

        [Column("SickLeaveHours", Order = 12, TypeName = "smallint")]
        public short SickLeaveHours { get; set; }

        [Column("CurrentFlag", Order = 13, TypeName = "bit")]
        public bool CurrentFlag { get; set; }

        [Column("rowguid", Order = 14, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 15, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//EmployeeDepartmentHistory Employee
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

//EmployeePayHistory Employee
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeePayHistory> EmployeePayHistories { get; set; }

//JobCandidate Employee
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobCandidate> JobCandidates { get; set; }

//Document Employee
            //PurchaseOrderHeader Employee
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

//SalesPerson Employee
                    public virtual SalesPerson SalesPerson { get; set; }

        public virtual Person Person { get; set; }

    }
}
