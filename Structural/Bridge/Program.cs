namespace Bridge
{
    internal static class Program
    {
        private static void Main()
        {
            IWeapon weapon1 = new Knife(new PoisoningEffect());
            weapon1.Stab();

            IWeapon weapon2 = new Knife(new ParalysisEffect());
            weapon2.Stab();


            IWeapon weapon3 = new Dagger(new PoisoningEffect());
            weapon3.Stab();
        }
    }
}