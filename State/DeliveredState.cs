namespace State
{
    public class DeliveredState : PackageState
    {
        public override void Proceed(Package package)
        {
            package.ChangeState(state: new ReceivedState());
        }

        public override void Revert(Package package)
        {
            package.ChangeState(state: new OrderedState());
        }

        public override void PrintStatus()
        {
            Console.WriteLine(value: "Package delivered to post office, not received yet.");
        }
    }
}
