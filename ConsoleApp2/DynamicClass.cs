using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp2
{
    internal class DynamicClass
    {
        public void dynamicFunction()
        {
            dynamic d1 = 7;
            dynamic d2 = "Be happy and save your health.";
            dynamic d3 = DateTime.Today.Day;
            dynamic d4 = Process.GetCurrentProcess().ProcessName;
            int v1 = d1 + d3;
            Console.WriteLine($"Todays date is {DateTime.Today.Date}, date sum with int value result: {v1} and process name: {d4}");
        }
    }
}
