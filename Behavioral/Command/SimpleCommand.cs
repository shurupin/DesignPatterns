namespace Command
{
    using System;

    // Some commands can implement simple operations on their own.
    class SimpleCommand : ICommand
    {
        private string _message;

        public SimpleCommand(string message)
        {
            this._message = message;
        }

        public void Execute()
        {
            Console.WriteLine(value: $"SimpleCommand: See, I can do simple things like printing ({this._message})");
        }
    }
}