using System;

namespace Command
{
    // The Receiver classes contain some important business logic.
    // They know how to perform all kinds of operations, associated with carrying out a request.
    // In fact, any class may serve as a Receiver.
    class Receiver
    {
        public void DoSomething(string work1)
        {
            Console.WriteLine($"Receiver: Working on ({work1}.)");
        }

        public void DoSomethingElse(string work2)
        {
            Console.WriteLine($"Receiver: Also working on ({work2}.)");
        }
    }
}