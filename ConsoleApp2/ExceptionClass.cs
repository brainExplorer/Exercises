using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace ConsoleApp2
{
    internal class ExceptionClass
    {
        public void exceptionFunc()
        {
            string myString = "true";
            // determines whether 2 instances is same. So it returns bool value.
            dynamic f = ProcessThread.ReferenceEquals(Thread.CurrentThread, Thread.CurrentThread);
            try
            {
                Console.WriteLine($"Is it true {f == myString}");
            }
            catch (Exception e)
            {
                throw new Exception(myString, e);
            }
            finally
            {
                Console.WriteLine($"Current thread : {Thread.CurrentThread}.");             
            }
        }       
    }
}
