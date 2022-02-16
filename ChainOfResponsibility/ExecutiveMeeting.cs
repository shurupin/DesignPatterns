namespace ChainOfResponsibility
{
    public class ExecutiveMeeting : Approver
    {
        private static readonly ExecutiveMeeting _instance = new();

        private ExecutiveMeeting()
        {
        }

        public static ExecutiveMeeting Instance => _instance;

        public override void Approve(Purchase purchase)
        {
            Console.WriteLine(
                value: $"Purchase #{purchase.Number} that cost {purchase.Cost:C} requires " +
                $"an executive meeting in order to be approved.");
        }
    }
}
