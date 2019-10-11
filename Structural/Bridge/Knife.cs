using System;

namespace Bridge
{
    public class Knife : IWeapon
    {
        protected readonly IEffect Effect;

        public Knife(IEffect effect)
        {
            this.Effect = effect;
        }

        public virtual void Stab()
        {
            Console.WriteLine("Knife stabbing");
            this.Effect.Apply();
        }
    }
}