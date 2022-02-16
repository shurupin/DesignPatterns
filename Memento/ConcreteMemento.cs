namespace Memento
{
    public class ConcreteMemento : IMemento
    {
        private readonly string _state;
        private readonly DateTime _creationDate;

        public ConcreteMemento(string state)
        {
            this._state = state;
            this._creationDate = DateTime.Now;
        }

        /// <summary>
        /// The Originator uses this method when restoring its state.
        /// </summary>
        /// <returns>State.</returns>
        public string GetState()
        {
            return this._state;
        }

        /// <summary>
        /// Used by the Caretaker to display metadata.
        /// </summary>
        /// <returns>Name.</returns>
        public string GetName()
        {
            return $"{this._creationDate:MM/dd/yyyy hh:mm:ss.fff tt} / ({this._state.Substring(startIndex: 0, length: 9)})...";
        }

        /// <summary>
        /// Used by the Caretaker to display metadata.
        /// </summary>
        /// <returns>Creation date.</returns>
        public DateTime GetCreationDate()
        {
            return this._creationDate;
        }
    }
}
