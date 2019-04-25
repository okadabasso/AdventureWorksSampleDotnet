using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureWorksSample1.Models4
{
    public class table7
    {
        [Column("id", Order = 0)]
        public int id { get; set; }

        [Column(Order = 1)]
        [StringLength(256)]
        public string name { get; set; }

        [Column(Order = 3)]
        [ForeignKey("refTable")]
        public int? table5_key1 { get; set; }

        [Column(Order = 4)]
        [ForeignKey("refTable")]
        public int? table5_key2 { get; set; }

        [Association("table5", "table5_key1,table5_key2", "key1,key2", IsForeignKey = true)]
        public virtual table5 refTable { get; set; }

        [Association("table5b", "table5_key1", "key1", IsForeignKey = true)]
        public virtual table5b refTable5b { get; set; }

    }
}
