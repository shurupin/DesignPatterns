namespace Command
{
    using System;

    // However, some commands can delegate more complex operations to other objects, called "receivers"
    class ComplexCommand : ICommand
    {
        private Receiver _receiver;

        // Context data, required for launching the receiver's methods
        private string _work1;

        private string _work2;

        // Complex commands can accept one or several receiver objects along with any context data via the constructor
        public ComplexCommand(Receiver receiver, string work1, string work2)
        {
            this._receiver = receiver;
            this._work1 = work1;
            this._work2 = work2;
        }

        // Commands can delegate to any methods of a receiver
        public void Execute()
        {
            Console.WriteLine(value: "ComplexCommand: Complex stuff should be done by a receiver object.");
            this._receiver.DoSomething(work1: this._work1);
            this._receiver.DoSomethingElse(work2: this._work2);
        }
    }
}