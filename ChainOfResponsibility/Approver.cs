namespace ChainOfResponsibility
{
    public abstract class Approver
    {
        protected Approver Next { get; private set; }

        public Approver RegisterNext(Approver next)
        {
            this.Next = next;
            return this.Next;
        }

        public abstract void Approve(Purchase purchase);
    }
}
