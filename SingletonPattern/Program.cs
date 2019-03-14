using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.Instance();
            Singleton singleton2 = Singleton.Instance();
            if (singleton1 == singleton2)
            {
                Console.WriteLine("Both instances of the singleton are the same");
            }
            Console.ReadLine();
        }
    }
}
