namespace State
{
    public class OrderedState : PackageState
    {
        public override void Proceed(Package package)
        {
            package.ChangeState(state: new DeliveredState());
        }

        public override void Revert(Package package)
        {
            Console.WriteLine(value: "State can't be reverted. Package is in ordered state, which is its initial state.");
        }

        public override void PrintStatus()
        {
            Console.WriteLine(value: "Package ordered, not delivered to the office yet.");
        }
    }
}
