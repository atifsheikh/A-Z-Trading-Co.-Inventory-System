using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firebirdtest.Classes
{
    public static class StaticClass
    {
        public static bool Contain(this string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }
    }
}
