# Executing some tasks before your API is ready

Say you want to load memory lists, before any call to your API happens, you can do with a few tweaks.

Researching on that matter, I stumbled across an article: 
https://andrewlock.net/reducing-latency-by-pre-building-singletons-in-asp-net-core/

The former article actually is not fit for my purpuse, but it used feature from a previous article by the same author:
https://andrewlock.net/running-async-tasks-on-app-startup-in-asp-net-core-part-2/

This second article was paramount for the developer of this demo and has many intersting points.
Just for teaching purpuses I toned the articles content down so you just have to take a few actions:

* Write an IStartupTask interface just like in the former article
* Write your IStartupTask implementation class
* Register your IStartupTask and its implementations at Startup.cs
* Change your *Program.cs* **Main** method from return type *void* to **async Task**
* Create a variable to store your host
* Create an asynchronous methdos to execute as many IStratupTask as you registered at Startup
* Update your Ready endpoint to check that your task is completed

```
public static async Task Main(string[] args)
{
    var host = CreateHostBuilder(args).Build();
    await ExecutePriorToReadyTask(host, CancellationToken.None);
    await host.RunAsync(CancellationToken.None);
}

private async static Task ExecutePriorToReadyTask(IHost host, CancellationToken cancellationToken)
{
    //This is a collection, so if you have to execute many tasks before startup you can
    var startupTaskCollection = host.Services.GetServices<IStartupTask>();
    // Execute all the tasks
    foreach (var startupTask in startupTaskCollection)
    {
        await startupTask.ExecuteAsync(cancellationToken);
    }
}
```

Done, now your tasks will execute before your api is ready
