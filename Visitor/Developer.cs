namespace Visitor
{
    public class Developer : IEmployee
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitDeveloper(developer: this);
        }

        public string ExclusiveMethodOfDeveloper()
        {
            return "Developer";
        }
    }
}
