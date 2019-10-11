using System;

namespace Bridge
{
    public class ParalysisEffect : IEffect
    {
        public void Apply()
        {
            Console.WriteLine("Paralysis effect is applied");
        }
    }
}