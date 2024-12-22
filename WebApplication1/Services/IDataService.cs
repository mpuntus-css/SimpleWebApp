namespace WebApplication1.Services
{
    public interface IDataService
    {
        Task<List<string>> GetDataAsync();
        Task SaveDataAsync(List<string> data);
    }
}
