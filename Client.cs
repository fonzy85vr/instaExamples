namespace insta_examples
{
    public class Client
    {
        public void Inizialize(){
            InitFactory(new ModernFactory());
            InitFactory(new ClassicFactory());
        }

        private void InitFactory(IAbstracatFactory factory){
            var chair = factory.CreateChair();
            Console.WriteLine(chair.WhoIAm());
            var table = factory.CreateTable();
            Console.WriteLine(table.WhoIAm());
        }
    }
}