namespace Adapter
{
    using System;

    class WhiteDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine(value: "Quack Quack Quack");
        }
    }
}