namespace insta_examples
{
    public abstract class AbstractChair
    {
        public virtual string WhoIAm (){
            return $"I'm a {this.GetType().Name}";
        }
    }
}