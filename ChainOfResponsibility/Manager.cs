namespace ChainOfResponsibility
{
    public class Manager : Approver
    {
        public override void Approve(Purchase purchase)
        {
            if (purchase.Cost < 500)
            {
                Console.WriteLine(value: $"Manager approved purchase #{purchase.Number} that cost {purchase.Cost:C}");
                return;
            }

            this.Next?.Approve(purchase: purchase);
        }
    }
}
