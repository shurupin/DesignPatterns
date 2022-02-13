namespace Bridge
{
    using System;

    public class PoisoningEffect : IEffect
    {
        public void Apply()
        {
            Console.WriteLine(value: "Poisoning effect is applied");
        }
    }
}