using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Person.Person_json")]
    public partial class PersonJson
    {
        public PersonJson()
        {
            PersonId = 0;
            PersonType = null;
            NameStyle = false;
            Title = null;
            FirstName = null;
            MiddleName = null;
            LastName = null;
            Suffix = null;
            EmailPromotion = 0;
            AdditionalContactInfo = null;
            Demographics = null;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>column:PersonID</summary>
        [Key]
        [Column("PersonID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }

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

        ///<summary>column:AdditionalContactInfo</summary>
        [Column("AdditionalContactInfo", Order = 9, TypeName = "nvarchar")]
        public string AdditionalContactInfo { get; set; }

        ///<summary>column:Demographics</summary>
        [Column("Demographics", Order = 10, TypeName = "nvarchar")]
        public string Demographics { get; set; }

        ///<summary>column:rowguid</summary>
        [Column("rowguid", Order = 11, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>column:ModifiedDate</summary>
        [Column("ModifiedDate", Order = 12, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

    }
}
