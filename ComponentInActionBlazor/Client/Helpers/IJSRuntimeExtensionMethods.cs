using Microsoft.JSInterop;

namespace ComponentInActionBlazor.Client.Helpers;

public static class IJSRuntimeExtensionMethods
{
    public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
    {
        await js.InvokeVoidAsync("console.log", "Tutaj jest info ześmy kliknęli");
        return await js.InvokeAsync<bool>("confirm", message);
    }

    public static async ValueTask MyFunction(this IJSRuntime js,string message)
    {
        await js.InvokeVoidAsync("my_function", message);
    }
}

