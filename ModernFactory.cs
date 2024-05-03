namespace insta_examples
{
    public class ModernFactory : IAbstracatFactory
    {
        public AbstractChair CreateChair()
        {
            return new ModernChair();
        }

        public AbstractTable CreateTable()
        {
            return new ModernTable();
        }
    }
}