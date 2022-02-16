namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator(state: "Initial state.");
            Caretaker caretaker = new Caretaker(originator: originator);
            caretaker.Backup();

            originator.DoSomething();
            caretaker.Backup();

            originator.DoSomething();
            caretaker.Backup();

            caretaker.ShowHistory();

            originator.DoSomething();

            Console.WriteLine(value: "\nClient: Now, let's rollback!\n");
            caretaker.Undo();

            Console.WriteLine(value: "\nClient: Once more!\n");
            caretaker.Undo();
        }
    }
}