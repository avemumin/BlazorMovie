using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace ComponentInActionBlazor.Client.Pages;
public partial class Counter
{
    [Inject] IJSRuntime js { get; set; }

    private int currentCount = 0;
    private static int currentCountStatic = 0;

    IJSObjectReference module;

    [JSInvokable]
    public async Task IncrementCount()
    {
        module = await js.InvokeAsync<IJSObjectReference>("import", "./js/Counter.js");
        await module.InvokeVoidAsync("displayAlert", "hello from allert");

        currentCount++;
        currentCountStatic++;
        await js.InvokeVoidAsync("dotnetStaticInvocation");
    }

    public async Task IncrementCountJavaScript()
    {
        await js.InvokeVoidAsync("dotnetInstanceInvocation",
            DotNetObjectReference.Create(this));
    }

    [JSInvokable]
    public static Task<int> GetCurrentCount()
    {
        return Task.FromResult(currentCountStatic);
    }
}

