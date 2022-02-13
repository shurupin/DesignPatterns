namespace Bridge
{
    using System;

    public class ParalysisEffect : IEffect
    {
        public void Apply()
        {
            Console.WriteLine(value: "Paralysis effect is applied");
        }
    }
}