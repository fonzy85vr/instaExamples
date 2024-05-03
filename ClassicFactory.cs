namespace insta_examples
{
    public class ClassicFactory : IAbstracatFactory
    {
        public AbstractChair CreateChair()
        {
            return new ClassicChair();
        }

        public AbstractTable CreateTable()
        {
            return new ClassicTable();
        }
    }
}