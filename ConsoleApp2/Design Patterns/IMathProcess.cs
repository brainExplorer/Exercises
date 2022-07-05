using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Design_Patterns
{
    internal interface IMathProcess
    {       
        public int? multiply(int[] multiplier);
        public double? division(double divisor1, double divisor2);
        public int? addition(int[] additioner);
        public int? subtract(int[] subtractor);
    }

    internal interface INumbers
    {
        public double? get2Number(int first, int second);
        public int? getNumbers(int[] ints, string processName);
    }



}


