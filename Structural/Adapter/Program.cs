namespace Adapter
{
    internal static class Program
    {
        private static void Main()
        {
            var blackRaven = new BlackRaven();
            var ravenAdapter = new RavenAdapter(blackRaven);
            ravenAdapter.Quack();
        }
    }
}
