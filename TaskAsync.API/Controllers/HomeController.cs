using System.Threading;

namespace TaskAsync.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeController(ITaskService _taskService) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        _taskService.TaskWhenAll();
        return Ok(Thread.CurrentThread.ManagedThreadId);
    }   
    [HttpGet("block")]
    public IActionResult BlockThread()
    {
        Thread.Sleep(10000);  // 10 saniye boyunca thread'i blokla
        return Ok(Thread.CurrentThread.ManagedThreadId);
    }
}
