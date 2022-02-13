namespace Adapter
{
    using System;

    class BlackRaven : IRaven
    {
        public void Croak()
        {
            Console.WriteLine(value: "Croak Croak Croak");
        }
    }
}