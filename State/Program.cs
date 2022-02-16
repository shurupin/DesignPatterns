namespace State
{
    using System;

    class Program
    {
        static void Main()
        {
            Package package = new Package();
            package.PrintStatus();

            package.Proceed();
            package.PrintStatus();

            package.Proceed();
            package.PrintStatus();

            package.Proceed();
            package.PrintStatus();
        }
    }
}