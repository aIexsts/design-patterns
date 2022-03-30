namespace Singleton.Singletons
{
    public class DoubleCheckedSingleton
    {
        static object Lock = new object();
        
        private static volatile DoubleCheckedSingleton doubleCheckedSingleton;
        // mark as volatile for synchronized block)

        private DoubleCheckedSingleton()
        {
        }

        public static DoubleCheckedSingleton getInstance()
        {
            if (doubleCheckedSingleton == null)
            {
                lock (Lock)
                {
                    if (doubleCheckedSingleton == null)
                    {
                        doubleCheckedSingleton = new DoubleCheckedSingleton();
                    }
                }
            }
            return doubleCheckedSingleton;
        }
    }
}
