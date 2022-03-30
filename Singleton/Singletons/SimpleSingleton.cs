namespace Singleton.Singletons
{
    public class SimpleSingleton
    {
        private static SimpleSingleton uniqueInstance = new SimpleSingleton(); // lazy

        private SimpleSingleton(){}

        public static SimpleSingleton getInstance(){
            return uniqueInstance;
        } 
    }
}
