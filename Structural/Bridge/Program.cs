namespace Bridge
{
    internal static class Program
    {
        private static void Main()
        {
            IWeapon weapon1 = new Knife(effect: new PoisoningEffect());
            weapon1.Stab();

            IWeapon weapon2 = new Knife(effect: new ParalysisEffect());
            weapon2.Stab();


            IWeapon weapon3 = new Dagger(effect: new PoisoningEffect());
            weapon3.Stab();
        }
    }
}