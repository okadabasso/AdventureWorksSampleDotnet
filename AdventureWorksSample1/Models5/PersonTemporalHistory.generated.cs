using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Person.Person_Temporal_History")]
    public partial class PersonTemporalHistory
    {
        public PersonTemporalHistory()
        {
            BusinessEntityId = 0;
            PersonType = null;
            NameStyle = false;
            Title = null;
            FirstName = null;
            MiddleName = null;
            LastName = null;
            Suffix = null;
            EmailPromotion = 0;
            ValidFrom = DateTime.Parse("0001/01/01 0:00:00");
            ValidTo = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>column:BusinessEntityID</summary>
        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityId { get; set; }

        ///<summary>column:PersonType</summary>
        [Required]
        [Column("PersonType", Order = 1, TypeName = "nchar")]
        [StringLength(2)]
        public string PersonType { get; set; }

        ///<summary>column:NameStyle</summary>
        [Column("NameStyle", Order = 2, TypeName = "bit")]
        public bool NameStyle { get; set; }

        ///<summary>column:Title</summary>
        [Column("Title", Order = 3, TypeName = "nvarchar")]
        [StringLength(8)]
        public string Title { get; set; }

        ///<summary>column:FirstName</summary>
        [Required]
        [Column("FirstName", Order = 4, TypeName = "nvarchar")]
        [StringLength(50)]
        public string FirstName { get; set; }

        ///<summary>column:MiddleName</summary>
        [Column("MiddleName", Order = 5, TypeName = "nvarchar")]
        [StringLength(50)]
        public string MiddleName { get; set; }

        ///<summary>column:LastName</summary>
        [Required]
        [Column("LastName", Order = 6, TypeName = "nvarchar")]
        [StringLength(50)]
        public string LastName { get; set; }

        ///<summary>column:Suffix</summary>
        [Column("Suffix", Order = 7, TypeName = "nvarchar")]
        [StringLength(10)]
        public string Suffix { get; set; }

        ///<summary>column:EmailPromotion</summary>
        [Column("EmailPromotion", Order = 8, TypeName = "int")]
        public int EmailPromotion { get; set; }

        ///<summary>column:ValidFrom</summary>
        [Column("ValidFrom", Order = 9, TypeName = "datetime2")]
        public DateTime ValidFrom { get; set; }

        ///<summary>column:ValidTo</summary>
        [Column("ValidTo", Order = 10, TypeName = "datetime2")]
        public DateTime ValidTo { get; set; }

    }
}
