using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class EventClass1
    {
        // Declare the delegate (if using non-generic pattern).
        public delegate void EventHandler();
        // Declare the event.
        public event EventHandler eventHandler;
        public void runMe()
        {
            Ran();
        }

        // Wrap the event in a protected virtual method
        // to enable derived classes to raise the event.
        protected virtual void Ran()
        {
            // Raise the event in a thread-safe manner using the ?. operator.
            eventHandler?.Invoke();
        }
    }
}

