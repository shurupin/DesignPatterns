namespace Command
{
    using System;

    // The Receiver classes contain some important business logic.
    // They know how to perform all kinds of operations, associated with carrying out a request.
    // In fact, any class may serve as a Receiver.
    class Receiver
    {
        public void DoSomething(string work1)
        {
            Console.WriteLine(value: $"Receiver: Working on ({work1}.)");
        }

        public void DoSomethingElse(string work2)
        {
            Console.WriteLine(value: $"Receiver: Also working on ({work2}.)");
        }
    }
}