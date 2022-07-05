using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Design_Patterns
{
    internal class MathProcess : IMathProcess
    {
        public int? addition(int[] additioner) => additioner?.Sum();

        public double? division(double divisor1, double divisor2) => divisor1/divisor2;

        public int? multiply(int[] multiplier) => multiplier.Aggregate((mult, e) => mult * e);

        public int? subtract(int[] subtractor) => subtractor?.Aggregate((sub, s) => sub - s);
    }
}
