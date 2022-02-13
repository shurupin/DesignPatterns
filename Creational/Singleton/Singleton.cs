namespace Singleton
{
    using System;

    internal class Singleton
    {
        // The Singleton's constructor should always be private to prevent direct construction calls with the `new` operator.
        private Singleton() { }

        // The Singleton's instance is stored in a static field. This is the simplest way to create singleton instance,
        // it also allows you to check whether or not the instance has been created yet with the IsValueCreated property, if you need that.
        private static readonly Lazy<Singleton> _singleton = new Lazy<Singleton>(valueFactory: () => new Singleton());

        // The `GetInstance` static method serves as an alternative to constructor
        // and lets clients access the same singleton instance over and over.
        public static Singleton GetInstance() => _singleton.Value;


        // Finally, any singleton should define some business logic, which can be executed on its instance.
        private int _count = 42;

        public void Increment()
        {
            this._count++;
            Console.WriteLine(value: $"Count = {this._count}");
        }
    }
}
