using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SumSub2DArray
    {
        public static int[] MaxSum(int[][] input)
        {
            
            int[] result = new int[input.Length];
            int tempSum = 0;
            foreach (var item in input)
            {
                if (tempSum < item.Sum())
                {
                    tempSum = item.Sum();
                }
            }
            Console.WriteLine(tempSum);
            return result;
        }
    }
}