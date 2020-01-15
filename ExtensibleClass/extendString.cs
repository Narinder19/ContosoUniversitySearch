using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtensibleClass
{
    public static class extendString 
    {
        public static string TrimAndReduce(this string str)
        {
            return RemoveWhiteSpaces(str).Trim();
        }
        
        public static string RemoveWhiteSpaces(this string s)
        {
            return Regex.Replace(s, @"\s+", " ");
        }


    }

   
}
