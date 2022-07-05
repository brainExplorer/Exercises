using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class TypeConversations
    {
        private void implicitTypeConv()
        {
            int first = 56;
            double second = first;
        }

        private void explicitTypeConv()
        {
            float first = 0.1F;
            int second = (int)first;
        }
        
        /*
         User-defined type conversion
         */
        private void userDefinedTypeConv()
        {
            B b = new B();
            A a = b; //implicit user-defined type conversion

            A c = (B) new A(); // explicit user-defined type conversion
        }
        class A { }
        class B:A { }
        /*
         Conversions with helper classes
         */
        private void conversationsHelperClasses()
        {
            string s = "2";
            int i = Convert.ToInt32(s);

            const string formatter = "{0,25}{1,30}";
            double aDoubl = 0.1111111111111111111;
            Console.WriteLine(formatter, aDoubl, BitConverter.ToString(BitConverter.GetBytes(aDoubl)));

            string str = "0xFA1B";
            int p = int.Parse(str);
        }
    }
}
