using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace ConsoleApp2
{
    internal class Triangle
    {        
        public static int MinimumTotal(IList<IList<int>> triangle) 
        {
            int total = 0;           
            if ( 0 < triangle.Count && 200 >= triangle.Count)
            {
                foreach (var item in triangle)
                {
                    total += item.Min();
                }                
            }
            return total;            
        }
        public static int MinimumNeighTotal(IList<IList<int>> triangle)
        {
            int total = 0;
            if (0 < triangle.Count && 200 >= triangle.Count)
            {
                List<int> keeper = triangle[0].ToList();
                total += triangle[0].Min();
                int tempIndex = 0;
                int tempTotal = 0;
                triangle.Remove(triangle[0]);
                foreach (var item in triangle)
                {
                    if (item.Count > keeper.Count && tempIndex == 0)
                    {
                        tempTotal = Math.Min(item[tempIndex], item[tempIndex + 1]);
                        tempIndex = item.IndexOf(tempTotal);
                        total += tempTotal;
                        Console.WriteLine($"Variable : {item[tempIndex]} , List Length : {item.Count}");
                    }

                    else if (item.Count > keeper.Count && tempIndex > 0)
                    {

                        tempTotal = Math.Min(item[tempIndex - 1], item[tempIndex]) > Math.Min(item[tempIndex - 1], item[tempIndex]) ?
                            Math.Min(item[tempIndex - 1], item[tempIndex - 1]) :
                            Math.Min(item[tempIndex - 1], item[tempIndex]);
                        tempIndex = item.IndexOf(tempTotal);
                        Console.WriteLine($"Variable : {item[tempIndex]} , List Length : {item.Count}");
                        total += tempTotal;
                    }
                }
            }
            return total;
        }

    }
}
