namespace insta_examples
{
    public class CsvImportService
    {
        public IEnumerable<string> GetCsvFile(){
            var csvFileContent = new List<string>();

            csvFileContent.Add("ID;Movement Date; Movement Description;Movement Type;Movement Amount;Movement Category");
            for(var i = 0; i < 10; i++){
                csvFileContent.Add($"{i};11-01-2024;Movimento {i};Uscita;11.00;Caffè");
            }

            return csvFileContent;
        }
    }
}