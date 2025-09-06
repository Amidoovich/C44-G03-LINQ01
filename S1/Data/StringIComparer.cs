using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1.Data
{
    internal class StringIComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            if (x is null && y is null)
                return 0;   
            if (x is null)
                return -1;              
            if (y is null)
                return 1;               

            return string.Compare(x.ToLower(), y.ToLower());
        }
    }
}
