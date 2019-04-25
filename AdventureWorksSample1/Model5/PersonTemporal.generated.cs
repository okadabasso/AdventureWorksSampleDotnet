using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Person.Person_Temporal")]
    public partial class PersonTemporal
    {
        [Key]
        [Column("BusinessEntityID", Order = 1, TypeName = "int")]
        public int BusinessEntityId { get; set; }
        [Column("PersonType", Order = 2, TypeName = "nchar")]
        [StringLength(2)]
        public string PersonType { get; set; }
        [Column("NameStyle", Order = 3, TypeName = "bit")]
        public bool NameStyle { get; set; }
        [Column("Title", Order = 4, TypeName = "nvarchar")]
        [StringLength(8)]
        public string Title { get; set; }
        [Column("FirstName", Order = 5, TypeName = "nvarchar")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Column("MiddleName", Order = 6, TypeName = "nvarchar")]
        [StringLength(50)]
        public string MiddleName { get; set; }
        [Column("LastName", Order = 7, TypeName = "nvarchar")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Column("Suffix", Order = 8, TypeName = "nvarchar")]
        [StringLength(10)]
        public string Suffix { get; set; }
        [Column("EmailPromotion", Order = 9, TypeName = "int")]
        public int EmailPromotion { get; set; }
        [Column("ValidFrom", Order = 10, TypeName = "datetime2")]
        public DateTime ValidFrom { get; set; }
        [Column("ValidTo", Order = 11, TypeName = "datetime2")]
        public DateTime ValidTo { get; set; }
        public PersonTemporal()
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
    }
}
