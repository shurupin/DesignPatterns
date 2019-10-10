using System;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            if (singleton1 == singleton2)
            {
                Console.WriteLine("Singleton works, both variables refer to the same instance.");
                singleton1.Increment();
                singleton2.Increment();
            }
            else
            {
                Console.WriteLine("Singleton failed, variables refer to different instances.");
            }
        }
    }
}
