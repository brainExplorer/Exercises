using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    partial class ClassCasting
    {
        public void implicitFunction()
        {
            Parent parent = new Child();
            Console.WriteLine($"Type of 'parent' object : {parent.GetType().Name}");
        }
        public void explicitFunc()
        {
            Parent parent = new Parent();
            Child child = (Child)parent;            
        }
    }

     internal class Parent
    {
        protected void myFunc()
        {           
            Console.WriteLine("Parent.myFunc() had been started.");            
        }
    }
    internal class Child: Parent
    {
        public Child()
        {
            //base.myFunc();
            Console.WriteLine($"Initialized Child class.");
        }
    }
}