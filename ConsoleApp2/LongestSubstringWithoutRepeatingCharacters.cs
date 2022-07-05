using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace ConsoleApp2
{
    internal class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s) => String.IsNullOrEmpty(s) 
            ? 0:(String.IsNullOrWhiteSpace(s) || s.Length==1
            ? s.Where(x => String.IsNullOrWhiteSpace(s) || Char.IsLetterOrDigit(x) || Char.IsSymbol(x) || Char.IsPunctuation(x) || Char.IsControl(x)).Distinct().Count() : 
            IsOrdered(s, s.Substring(0, s.Length - 1)).Item1 
            ? (s.Substring(0, s.Length - 1).Distinct().Count()) : s.Substring(IsOrdered(s, s.Substring(0, s.Length - 1)).Item2,s.Length-1).Length);
        public Tuple<bool, int> IsOrdered(string str, string subStr)
        {
            bool isOrdered = false;
            string tempStr = "";
            int i;
            for (i = 0; i < subStr.ToArray().Length; i++)
            {
                tempStr = str.Substring(i, str.Length - 1);
                if (str.Contains(tempStr))
                {
                    isOrdered = true;
                    break;
                }
            }
            return Tuple.Create(isOrdered,i);
        }    
    }
}