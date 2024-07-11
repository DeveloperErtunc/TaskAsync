HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.AddDependencyInjection().HttpClientAdd();
IHost host = builder.Build();
var _taskService = host.Services.GetRequiredService<ITaskService>();

//ContinueWith
//await _taskService.TaskContinueWith();

//WhenAll  thread blocklanmaz,tüm hepsinin bitmesini bekler
//await _taskService.TaskWhenAll();

//WhenAny thread blocklanmaz. ilk bitini döner
///await _taskService.TaskWhenAny();

//TaskWaitAll thread block geriye deger dönmez ama task deger kullanılabilir
//_taskService.TaskWaitAll();

//WaitAny ilk tamamlanan indexsi döner thread block
//_taskService.TaskWaitAny();
