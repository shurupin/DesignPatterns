using System;

namespace Singleton
{
    // The Singleton class defines the `GetInstance` method that serves as an
    // alternative to constructor and lets clients access the same instance of
    // this class over and over.
    internal partial class Singleton
    {
        // The Singleton's constructor should always be private to prevent
        // direct construction calls with the `new` operator.
        private Singleton() { }

        // The Singleton's instance is stored in a static field. This is the simplest way to create singleton instance,
        // it also allows you to check whether or not the instance has been created yet with the IsValueCreated property, if you need that.
        private static readonly Lazy<Singleton> _singleton = new Lazy<Singleton>(() => new Singleton());

        // This is the static method that controls the access to the singleton instance
        public static Singleton GetInstance() => _singleton.Value;


        // Finally, any singleton should define some business logic, which can be executed on its instance.
        private int _count = 42;
   
        public void Increment()
        {
            _count++;
            Console.WriteLine($"Count = {_count}");
        }
    }
}
