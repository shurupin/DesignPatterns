using System;

namespace Bridge
{
    class Dagger : Knife
    {
        public Dagger(IEffect effect) : base(effect)
        {
        }

        public override void Stab()
        {
            Console.WriteLine("Dagger stabbing");
            this.Effect.Apply();
        }
    }
}
