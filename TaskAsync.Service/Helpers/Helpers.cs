namespace TaskAsync.Service.Helper;

public  class Helpers
{
    public async static Task<Content> GetContentAsync(string url)
    {
        var data = await new HttpClient().GetStringAsync(url);
        Console.WriteLine("GetContentAsync thread :" + Thread.CurrentThread.ManagedThreadId);
        return new Content(url, data.Length);
    }

}
