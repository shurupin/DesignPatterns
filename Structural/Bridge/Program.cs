namespace Bridge
{
    internal static class Program
    {
        private static void Main()
        {
            IWeapon weapon1 = new Knife(new PoisoningEffect());
            weapon1.Stab();
            
            IWeapon weapon2 = new Dagger(new PoisoningEffect());
            weapon2.Stab();

            IWeapon weapon3 = new Knife(new ParalysisEffect());
            weapon3.Stab();
        }
    }
}