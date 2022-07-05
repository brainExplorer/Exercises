using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Design_Patterns
{
    internal class Number : INumbers
    {
        public readonly IMathProcess _process;
        public Number()
        {
            _process = new MathProcess();
        }
        public Number(IMathProcess process)
        {
            _process = process;
        }

        public double? get2Number(int first, int second) => _process.division(first,second);
        public int? getNumbers(int[] ints, string processName) => processName=="m" ? _process.multiply(ints): 
                                                                                processName.ToLower()=="a" ? _process.addition(ints): _process.subtract(ints);
    }
}

