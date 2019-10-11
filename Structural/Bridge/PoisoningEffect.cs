using System;

namespace Bridge
{
    public class PoisoningEffect : IEffect
    {
        public void Apply()
        {
            Console.WriteLine("Poisoning effect is applied");
        }
    }
}