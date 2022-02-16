namespace Observer
{
    using System;

    class Program
    {
        static void Main()
        {
            DailyMail dailyMail = new DailyMail();
            dailyMail.Subscribe(user: new User(name: "Emma Davis", availableMonthlySubscriptionAmount: 5));
            dailyMail.Subscribe(user: new User(name: "Mary Miller", availableMonthlySubscriptionAmount: 10));
            dailyMail.Subscribe(user: new User(name: "Ube Miller", availableMonthlySubscriptionAmount: 6));

            Console.WriteLine();
            dailyMail.MonthlyPrice = 6;

            Console.WriteLine();
            dailyMail.MonthlyPrice = 8;
        }
    }
}