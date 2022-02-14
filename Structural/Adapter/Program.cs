namespace Adapter
{
    internal static class Program
    {
        private static void Main()
        {
            WhiteDuck whiteDuck = new WhiteDuck();
            whiteDuck.Quack();

            BlackRaven blackRaven = new BlackRaven();
            blackRaven.Croak();

            RavenAdapter ravenAdapter = new RavenAdapter(raven: blackRaven);
            ravenAdapter.Quack();

            IDuck[] ducks = { whiteDuck, ravenAdapter };
            foreach (IDuck duck in ducks)
            {
                duck.Quack();
            }
        }
    }
}