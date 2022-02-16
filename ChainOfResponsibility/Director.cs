namespace ChainOfResponsibility
{
    public class Director : Approver
    {
        public override void Approve(Purchase purchase)
        {
            if (purchase.Cost < 1000)
            {
                Console.WriteLine(value: $"Director approved purchase #{purchase.Number} that cost {purchase.Cost:C}");
                return;
            }

            this.Next?.Approve(purchase: purchase);
        }
    }
}
