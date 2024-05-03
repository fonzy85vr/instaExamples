namespace insta_examples
{
    public abstract class AbstractTable
    {
        public virtual string WhoIAm (){
            return $"I'm a {this.GetType().Name}";
        }
    }
}