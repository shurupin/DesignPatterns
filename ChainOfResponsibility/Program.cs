namespace ChainOfResponsibility
{
    class Program
    {
        static void Main()
        {
            Approver manager = new Manager();
            Approver director = new Director();
            Approver vicePresident = new VicePresident();
            Approver president = new President();

            manager
                .RegisterNext(next: director)
                .RegisterNext(next: vicePresident)
                .RegisterNext(next: president)
                .RegisterNext(next: ExecutiveMeeting.Instance);

            Purchase lowCostPurchase = new Purchase { Number = 1, Cost = 400, Purpose = "Whiteboard purchase." };
            Purchase mediumCostPurchase = new Purchase { Number = 2, Cost = 3000, Purpose = "Laptops purchase." };
            Purchase highCostPurchase = new Purchase { Number = 3, Cost = 11500, Purpose = "Car purchase." };

            manager.Approve(purchase: lowCostPurchase);
            manager.Approve(purchase: mediumCostPurchase);
            manager.Approve(purchase: highCostPurchase);
        }
    }
}