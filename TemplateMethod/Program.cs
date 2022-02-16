namespace TemplateMethod
{
    using System;

    class Program
    {
        static void Main()
        {
            WhiteBread whiteBread = new WhiteBread();
            whiteBread.Make();

            Console.WriteLine();

            WholeWheatBread wholeWheatBread = new WholeWheatBread();
            wholeWheatBread.Make();
        }
    }
}