using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace ComponentInActionBlazor.Client.Pages;
public partial class Counter
{
    [Inject] IJSRuntime js { get; set; }

    private int currentCount = 0;
    private static int currentCountStatic = 0;
    private async Task IncrementCount()
    {
        currentCount++;
        currentCountStatic++;
        await js.InvokeVoidAsync("dotnetStativInvocation");
    }

    [JSInvokable]
    public static Task<int> GetCurrentCount()
    {
        return Task.FromResult(currentCountStatic);
    }
}

