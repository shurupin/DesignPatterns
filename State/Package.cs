namespace State
{
    public class Package
    {
        private PackageState _state = new OrderedState();

        public void Proceed()
        {
            this._state.Proceed(package: this);
        }

        public void Revert()
        {
            this._state.Revert(package: this);
        }

        public void PrintStatus()
        {
            this._state.PrintStatus();
        }

        public void ChangeState(PackageState state)
        {
            this._state = state;
        }
    }
}
