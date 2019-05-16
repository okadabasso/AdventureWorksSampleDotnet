using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schema
{
    public class AssociationRole
    {
        public string RoleName { get; set; }
        public string Multiplicity { get; set; }

        public bool Required { get; set; }

        public string ReferenceName { get; set; }

        public List<string> Columns { get; set; }
    }
}
