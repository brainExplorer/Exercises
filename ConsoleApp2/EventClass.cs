using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class EventClass
    {
        private delegate void DelegateSomeFunc(object o);
        private event DelegateSomeFunc eventFunc;
        private int _voltagevalue=0;
        private int _timevalue=0;
        private int _r=0;
        public int VoltageValue 
        {
            get { return _voltagevalue; }
            set { _voltagevalue = value; }
        }
        public void runIt()
        {
            
            Tuple<int, int> time =new Tuple<int, int>( DateTime.Now.Second,(DateTime.Now.Minute < 57 ? DateTime.Now.Minute + 2 : 0));
            try
            {
                _timevalue = time.Item1;
                while (true && DateTime.Now.Minute < time.Item2)
                {
                    Thread.Sleep(1000);                    
                    _timevalue += PositiveFiveVoltage();
                    _r = _timevalue/(30-_timevalue);
                    Console.WriteLine($"Item2 : {time.Item2} , Now.Second : {DateTime.Now.Minute}");
                }
            }
            catch (DivideByZeroException)
            {
                _timevalue +=NegativeFifteenVoltage();
                StaySafe();   
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public int PositiveFiveVoltage()
        {
            return 5;

        }
        public int NegativeFifteenVoltage()
        {
            return -15;
        }
        protected virtual void StaySafe()
        {
            eventFunc?.Invoke(this);
        }
    }
}
