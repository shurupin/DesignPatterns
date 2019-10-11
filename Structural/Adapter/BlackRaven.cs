using System;

namespace Adapter
{
    class BlackRaven : IRaven
    {
        public void Croak()
        {
            Console.WriteLine("Croak Croak Croak");
        }
    }
}