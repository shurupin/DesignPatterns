namespace State
{
    public abstract class PackageState
    {
        public abstract void Proceed(Package package);

        public abstract void Revert(Package package);

        public abstract void PrintStatus();
    }
}
