using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class CodeWarsArray
    {
  
        public static int[] arr = new int[] { };
        public static int[] array = new int[] { };
        public static void MoveZeroes()
        {
            arr.ToList();
            List<int> zeroKeeper = new List<int>();
            List<int> nonZeroKeeper = new List<int>();
            foreach (var item in arr)
            {
                if (item.Equals(0))
                {
                    zeroKeeper.Add(item);
                }
                else
                {
                    nonZeroKeeper.Add(item);
                }
            }
            zeroKeeper.ForEach(item => nonZeroKeeper.Add(item));
            array = nonZeroKeeper.ToArray();
            Console.WriteLine($"{array.Length}, {nonZeroKeeper.Count}, {zeroKeeper.Count}");
        }
    }
}
