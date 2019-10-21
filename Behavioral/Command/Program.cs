namespace Command
{
    class Program
    {
        static void Main()
        {
            // The client code can parameterize an invoker with any commands.
            Invoker invoker = new Invoker();

            SimpleCommand simpleCommand = new SimpleCommand(message: "Hello, World!");
            invoker.SetOnStart(simpleCommand);

            ComplexCommand complexCommand = new ComplexCommand(receiver: new Receiver(), work1: "Send email", work2: "Save report");
            invoker.SetOnFinish(complexCommand);

            invoker.DoSomethingImportant();
        }
    }
}