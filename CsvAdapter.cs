
namespace insta_examples
{
    public class CsvAdapter : IFileFormatTarget
    {
        public string GetJsonObject()
        {
            var csv = new CsvImportService().GetCsvFile();
            var json = "";

            // logica di conversione da csv a json

            return json;
        }

        public IEnumerable<Movement> GetMovements()
        {
            var csv = new CsvImportService().GetCsvFile();
            var movements = new List<Movement>();

            // logica conversione csv -> oggetto

            return movements;
        }
    }
}