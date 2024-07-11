namespace TaskAsync.Service.IServices;

public interface ITaskService
{
    Task TaskContinueWith();
    Task TaskWhenAll();
    Task TaskWhenAny();
    void TaskWaitAll();
    void TaskWaitAny();
}