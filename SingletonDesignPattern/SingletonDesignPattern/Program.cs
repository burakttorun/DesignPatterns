using System;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instance1 = Singleton.Instance;
            Singleton instance2 = Singleton.Instance;

            if (instance1.Equals(instance2))
            {
                Console.WriteLine("Instance are equals.");
            }
            if (instance1.GetHashCode() == instance2.GetHashCode())
            {
                Console.WriteLine("Instance's referances are equals.");
            }

            Console.ReadLine();
        }
    }
}
