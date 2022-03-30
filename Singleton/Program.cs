using Singleton.Singletons;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleSingleton = SimpleSingleton.getInstance();
            var doubleCheckedSingleton = DoubleCheckedSingleton.getInstance();
        }
    }
}
