namespace State
{
    public class ReceivedState : PackageState
    {
        public override void Proceed(Package package)
        {
            Console.WriteLine(value: "Package is already received by a client. There is nothing else left to do.");
        }

        public override void Revert(Package package)
        {
            package.ChangeState(state: new DeliveredState());
        }

        public override void PrintStatus()
        {
            Console.WriteLine(value: "Package received by a client.");
        }
    }
}
