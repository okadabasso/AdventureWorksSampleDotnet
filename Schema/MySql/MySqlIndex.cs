using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Schema.MySql
{
    class MySqlIndex
    {
        [Column("Table")]
        public string Table { get; set; }

        [Column("Non_unique")]
        public long NonUnique { get; set; }

        [Column("Key_name")]
        public string KeyName { get; set; }

        [Column("Seq_in_index")]
        public long SeqInIndex { get; set; }

        [Column("Column_name")]
        public string ColumnName { get; set; }

        [Column("Collation")]
        public string Collation { get; set; }

        [Column("Cardinality")]
        public long? Cardinality { get; set; }

        [Column("Sub_part")]
        public long? SubPart { get; set; }

        [Column("Packed")]
        public string Packed { get; set; }

        [Column("Null")]
        public string Null { get; set; }

        [Column("Index_type")]
        public string IndexType { get; set; }

        [Column("Comment")]
        public string Comment { get; set; }

        [Column("Index_comment")]
        public string IndexComment { get; set; }
    }
}
