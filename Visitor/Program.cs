namespace Visitor
{
    using System;

    class Program
    {
        static void Main()
        {
            List<IEmployee> employees = new List<IEmployee>
            {
                new Developer(),
                new Manager()
            };

            IncomeVisitor incomeVisitor = new IncomeVisitor();
            foreach (IEmployee employee in employees)
            {
                employee.Accept(visitor: incomeVisitor);
            }
            Console.WriteLine();

            PaidTimeOffVisitor paidTimeOffVisitor = new PaidTimeOffVisitor();
            foreach (IEmployee employee in employees)
            {
                employee.Accept(visitor: paidTimeOffVisitor);
            }
        }
    }
}