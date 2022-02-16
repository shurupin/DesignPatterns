namespace Visitor
{
    public interface IEmployee
    {
        void Accept(IVisitor visitor);
    }
}
