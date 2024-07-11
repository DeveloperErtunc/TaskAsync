namespace TaskAsync.Service.IServices;

public interface IReadService
{
    string ReadFile();
    Task<string> ReadFileAsync();
}
