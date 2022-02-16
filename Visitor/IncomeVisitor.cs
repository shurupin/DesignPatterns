namespace Visitor
{
    class IncomeVisitor : IVisitor
    {
        public void VisitDeveloper(Developer developer)
        {
            Console.WriteLine(value: developer.ExclusiveMethodOfDeveloper() + " + IncomeVisitor");
        }

        public void VisitManager(Manager manager)
        {
            Console.WriteLine(value: manager.SpecialMethodOfManager() + " + IncomeVisitor");
        }
    }
}
