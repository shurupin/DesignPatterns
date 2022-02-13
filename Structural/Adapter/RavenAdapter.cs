namespace Adapter
{
    public class RavenAdapter : IDuck
    {
        private readonly IRaven _raven;

        public RavenAdapter(IRaven raven)
        {
            this._raven = raven;
        }

        public void Quack()
        {
            this._raven.Croak();
        }
    }
}