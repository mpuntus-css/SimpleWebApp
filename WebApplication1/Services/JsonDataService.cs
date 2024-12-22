using System.Text.Json;

namespace WebApplication1.Services
{
    public class JsonDataService : IDataService
    {
        
        
        private readonly string _filePath;
        public JsonDataService(string filePath)
        {
            _filePath = filePath;
        }

        public async Task<List<string>> GetDataAsync()
        {
            if (!File.Exists(_filePath))
            {
                return new List<string>();
            }
                

            var jsonData = await File.ReadAllTextAsync(_filePath);

            var deserializedData = JsonSerializer.Deserialize<List<string>>(jsonData);

            if (deserializedData == null)
            {
                return new List<string>();
            }

            return deserializedData;
        }

        public async Task SaveDataAsync(List<string> data)
        {
            var jsonData = JsonSerializer.Serialize(data);
            await File.WriteAllTextAsync(_filePath, jsonData);
        }


    }

    
}
