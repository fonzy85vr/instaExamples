namespace insta_examples
{
    public interface IAbstracatFactory
    {
        AbstractChair CreateChair();
        AbstractTable CreateTable();
    }
}