namespace ChainOfResponsibility
{
    public class VicePresident : Approver
    {
        public override void Approve(Purchase purchase)
        {
            if (purchase.Cost < 2000)
            {
                Console.WriteLine(value: $"Vice president approved purchase #{purchase.Number} that cost {purchase.Cost:C}");
                return;
            }

            this.Next?.Approve(purchase: purchase);
        }
    }
}
