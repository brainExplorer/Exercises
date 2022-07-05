namespace ConsoleApp2
{
    internal sealed class SingletonClass
    {
        private SingletonClass(){}

        // It creates the thread-safe lazy initializer for SingletonClass
        private static readonly Lazy<SingletonClass> instance = new Lazy<SingletonClass>(() => new SingletonClass());

        // It creates a single object for the other classes.
        public static SingletonClass Instance
        {
            get
            {
                // it maybe seen bad idea, but i wanna show IValueCreated.
                if(!instance.IsValueCreated)
                {
                    return new SingletonClass();
                }
                // however following one line code is enough for this sample.
                return instance.Value;
            }
        }
        public string GetThreadVal()
        {
            return Thread.CurrentThread.Name="Singleton Thread";
        }
    }
}



