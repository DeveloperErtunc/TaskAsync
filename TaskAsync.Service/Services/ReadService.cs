namespace TaskAsync.Service.Services;

public class ReadService: IReadService
{
    public string ReadFile()
    {
        using (StreamReader streamReader = new StreamReader(StringConstants.UrlOfFile))
        {
            Thread.Sleep(3000);
            return streamReader.ReadToEnd();
        }
    }

    public async Task<string> ReadFileAsync()
    {
        using (StreamReader streamReader = new StreamReader(StringConstants.UrlOfFile))
        {
            await Task.Delay(3000);
            return await streamReader.ReadToEndAsync();
        }
    }
}
