namespace insta_examples
{
    public interface IFileFormatTarget
    {
        string GetJsonObject();
        IEnumerable<Movement> GetMovements();
    }
}