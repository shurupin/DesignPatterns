namespace Visitor
{
    public interface IVisitor
    {
        void VisitDeveloper(Developer developer);

        void VisitManager(Manager manager);
    }
}
