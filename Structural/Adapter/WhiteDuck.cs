using System;

namespace Adapter
{
    class WhiteDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack Quack");
        }
    }
}