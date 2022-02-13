namespace Bridge
{
    using System;

    class Dagger : Knife
    {
        public Dagger(IEffect effect) : base(effect: effect)
        {
        }

        public override void Stab()
        {
            Console.WriteLine(value: "Dagger stabbing");
            this.Effect.Apply();
        }
    }
}
