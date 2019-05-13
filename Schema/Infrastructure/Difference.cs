using System;
using System.Collections.Generic;
using System.Text;

namespace Schema.Infrastructure
{
    public class Difference
    {
        public bool Modified { get; set; }
        public int OriginalStart { get; set; }
        public int OriginalLength { get; set; }
        public int ModifiedStart { get; set; }
        public int ModifiedLength { get; set; }

        public Difference(bool modified, int originalStart, int originalLength, int modifiedStart, int modifiedLength)
        {
            this.Modified = modified;
            this.OriginalStart = originalStart;
            this.OriginalLength = originalLength;
            this.ModifiedStart = modifiedStart;
            this.ModifiedLength = modifiedLength;
        }

        public override string ToString()
        {
            return string.Format("{0} {1},{2} : {3},{4}",
                Modified ? "modified" : "common",
                OriginalStart,
                OriginalLength,
                ModifiedStart,
                ModifiedLength

                );
        }

    }
}
