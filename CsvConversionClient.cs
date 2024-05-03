namespace insta_examples
{
    public class CsvConversionClient
    {
        IFileFormatTarget _target;
        public CsvConversionClient(IFileFormatTarget target)
        {
            _target = target;
        }

        public string GetJson(){
            return _target.GetJsonObject();
        }

        public IEnumerable<Movement> GetMovements(){
            return _target.GetMovements();
        }
    }
}