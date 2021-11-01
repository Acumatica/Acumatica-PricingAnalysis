namespace TestFreightPrice.EntityDataService
{
    public interface FileDataProvider
    {
        string FilePath { get; set; }
        T Get<T>();
    }
}
