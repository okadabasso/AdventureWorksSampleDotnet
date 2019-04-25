using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schema
{
    public class ForeignKey
    {
        public string ConstraintSchema { get; set; }

        public string ConstraintName { get; set; }

        public string BaseTableSchema { get; set; }

        public string BaseTableName { get; set; }
        public string ReferencedTableSchema { get; set; }

        public string ReferencedTableName { get; set; }

        public List<string> Columns { get; set; }

        public List<string> ReferenceColumns { get; set; }
    }
}
