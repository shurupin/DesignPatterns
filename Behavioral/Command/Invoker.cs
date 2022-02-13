namespace Command
{
    using System;

    // The Invoker is associated with one or several commands. It sends a request to the command.
    class Invoker
    {
        private ICommand _onStart;

        private ICommand _onFinish;

        // Initialize commands.
        public void SetOnStart(ICommand command)
        {
            this._onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            this._onFinish = command;
        }

        // The Invoker does not depend on concrete command or receiver classes.
        // The Invoker passes a request to a receiver indirectly, by executing a command.
        public void DoSomethingImportant()
        {
            Console.WriteLine(value: "Invoker: Does anybody want something done before I begin?");
            this._onStart?.Execute();

            Console.WriteLine(value: "Invoker: ...doing something really important...");

            Console.WriteLine(value: "Invoker: Does anybody want something done after I finish?");
            this._onFinish?.Execute();
        }
    }
}