namespace ChainOfResponsibility
{
    public class President : Approver
    {
        public override void Approve(Purchase purchase)
        {
            if (purchase.Cost < 5000)
            {
                Console.WriteLine(value: $"President approved purchase #{purchase.Number} that cost {purchase.Cost:C}");
                return;
            }

            this.Next?.Approve(purchase: purchase);
        }
    }
}
