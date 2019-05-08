using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models6
{
    [Table("dbo.Users")]
    public partial class Users
    {
        public Users()
        {
            Id = 0;
            Name = null;
            CreatedAt = null;

        }

        ///<summary>column:Id</summary>
        [Key]
        [Column("Id", Order = 0, TypeName = "bigint")]
        public long Id { get; set; }

        ///<summary>column:Name</summary>
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        public string Name { get; set; }

        ///<summary>column:CreatedAt</summary>
        [Column("CreatedAt", Order = 2, TypeName = "datetime2")]
        public DateTime? CreatedAt { get; set; }

    }
}
