namespace ConsoleApp2
{
    internal class AsyncTask
    {
        public AsyncTask()
        {
           Task.WaitAny(GetSomeValues());
        }
        public async Task GetSomeValues() 
        {
            try
            {
                Action<string> action;
                //We don't need to all tasks are completed, if any task completed it continue to next task.
                await Task.WhenAny(Delay1kms(), Delay2kms(), Delay3kms());
                action = Output;
                action("Maybe some DelayTasks Completed");
                //Following code waiting for all tasks completed.
                float[] fArr = await Task.WhenAll(DoWorkA(), DoWorkB(), DoWorkC());
                for (int i = 0; i <= fArr.GetUpperBound(0); i++)
                {
                     action(fArr[i].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }           
        }           
        private static void Output(string val) => Console.WriteLine($"\r\n {val}");
        private async Task Delay1kms() { await Task.Delay(1000); Output($"{nameof(Delay1kms)} completed in 1 second."); }
        private async Task Delay2kms() { await Task.Delay(2000); Output($"{nameof(Delay2kms)} completed in 2 seconds."); }
        private async Task Delay3kms() { await Task.Delay(3000); Output($"{nameof(Delay3kms)} completed in 3 seconds."); }
        private async Task<float> DoWorkA() { await Task.Delay(1000); return 1; }
        private async Task<float> DoWorkB() { await Task.Delay(1200); return 1.2F; }
        private async Task<float> DoWorkC() { await Task.Delay(3300); return 3.3F; }
    }
}


