using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSQL
{
    public static class Extends
    {
        public static bool IsNullOrEmpty(this string text)
        {
            bool result = string.IsNullOrEmpty(text);
            return result;
        }
    }
}
