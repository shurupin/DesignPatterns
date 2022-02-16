namespace Visitor
{
    public class Manager : IEmployee
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitManager(manager: this);
        }

        public string SpecialMethodOfManager()
        {
            return "Manager";
        }
    }
}
