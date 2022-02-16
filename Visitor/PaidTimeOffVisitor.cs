namespace Visitor
{
    class PaidTimeOffVisitor : IVisitor
    {
        public void VisitDeveloper(Developer developer)
        {
            Console.WriteLine(value: developer.ExclusiveMethodOfDeveloper() + " + PaidTimeOffVisitor");
        }

        public void VisitManager(Manager manager)
        {
            Console.WriteLine(value: manager.SpecialMethodOfManager() + " + PaidTimeOffVisitor");
        }
    }
}
