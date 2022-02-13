namespace Adapter
{
    internal static class Program
    {
        private static void Main()
        {
            WhiteDuck whiteDuck = new WhiteDuck();
            whiteDuck.Quack();

            BlackRaven blackRaven = new BlackRaven();
            RavenAdapter ravenAdapter = new RavenAdapter(raven: blackRaven);
            ravenAdapter.Quack();
        }
    }
}