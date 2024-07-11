namespace TaskAsync.Service.Services;

public class TaskService(ISnowService _snowService) : ITaskService
{
    public async Task TaskContinueWith()
    {
        var task = _snowService.GetCitiesSnowResponse(StringConstants.Usa).ContinueWith(data => _snowService.ContinueWithCities(data, 30));
        Console.WriteLine("---------you can make your thing---------------------------");
        await task;
    }

    //
    public async Task TaskWhenAll()
    {
        var content = await Task.WhenAll(GetTasks());
        var contentList = content.ToList();
        contentList.ForEach(x => Console.WriteLine($"Site :{x.Site} - Length :{x.Lenght}"));
    }
    //WhenAny ilk biteni döner.
    public async Task TaskWhenAny()
    {
        var contentFirstCompleled = await Task.WhenAny(GetTasks());
        var content =await contentFirstCompleled;
        Console.WriteLine($"Site :{content.Site} - Length :{content.Lenght}");
    }

    public  void TaskWaitAll()
    {
        var tasks = GetTasks();
        Console.WriteLine("WaitAll before");
        Task.WaitAll(tasks.ToArray());
        Console.WriteLine("WaitAll after ");
        tasks.ForEach(x => Console.WriteLine($"Site :{x.Result.Site} - Length :{x.Result.Lenght}"));
    }
    public void TaskWaitAny()
    {
        var tasks = GetTasks();
        Console.WriteLine("WaitAll before");
        var firstTaskIndex = Task.WaitAny(tasks.ToArray());
        Console.WriteLine("WaitAll after ");
        Console.WriteLine($"Site :{tasks[firstTaskIndex].Result.Site} - Length :{tasks[firstTaskIndex].Result.Lenght}");
    }

    private List<Task<Content>> GetTasks()
    {
        List<Task<Content>> contents = new List<Task<Content>>();
        Console.WriteLine("Main Thread :" + Thread.CurrentThread.ManagedThreadId);
        var list = new List<string>() {
            "https://www.google.com",
            "https://www.microsoft.com",
            "https://www.amozon.com",
        };
        list.ForEach(x => contents.Add(Helpers.GetContentAsync(x)));
        return contents;   
    }
}
