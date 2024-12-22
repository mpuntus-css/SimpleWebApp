namespace WebApplication1.Services
{
    public class LoggingDataService : IDataService
    {
        private readonly IDataService _innerDataService;

        public LoggingDataService(IDataService innerDataService)
        {
            _innerDataService = innerDataService;
        }

        public async Task<List<string>> GetDataAsync()
        {
            Console.WriteLine("Fetching data...");
            return await _innerDataService.GetDataAsync();
        }

        public async Task SaveDataAsync(List<string> data)
        {
            Console.WriteLine("Saving data...");
            await _innerDataService.SaveDataAsync(data);
        }
    }
}
