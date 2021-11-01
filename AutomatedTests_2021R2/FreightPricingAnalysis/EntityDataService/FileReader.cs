using Newtonsoft.Json;
using System;
using System.IO;

namespace TestFreightPrice.EntityDataService
{
    public class FileReader : FileDataProvider
    {
        public string FilePath { get; set; }

        public T Get<T>()
        {
            try
            {
                var fileData = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<T>(fileData); ;
            }
            catch (Exception e)
            {
                throw new FileNotFoundException($"Error: {nameof(FileReader)}, file: {FilePath}, error: {e}");
            }
        }
    }
}
