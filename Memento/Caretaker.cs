namespace Memento
{
    public class Caretaker
    {
        private readonly Stack<IMemento> _mementos;
        private readonly Originator _originator;

        public Caretaker(Originator originator)
        {
            this._originator = originator;
            this._mementos = new Stack<IMemento>();
        }

        public void Backup()
        {
            Console.WriteLine(value: "Caretaker: Saving Originator's state...");

            this._mementos.Push(item: this._originator.Save());
        }

        public void Undo()
        {
            if (this._mementos.Count == 0)
            {
                return;
            }

            IMemento memento = this._mementos.Pop();
            Console.WriteLine(value: $"Caretaker: Restoring state to: {memento.GetName()}");

            try
            {
                this._originator.Restore(memento: memento);
            }
            catch (Exception)
            {
                this.Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine(value: "\nCaretaker: Here's the list of mementos:");

            foreach (IMemento memento in this._mementos)
            {
                Console.WriteLine(value: memento.GetName());
            }
        }
    }
}
