namespace Adapter
{
    public class RavenAdapter : IDuck
    {
        private readonly IRaven _raven;

        public RavenAdapter(IRaven raven)
        {
            _raven = raven;
        }

        public void Quack()
        {
            _raven.Croak();
        }
    }
}