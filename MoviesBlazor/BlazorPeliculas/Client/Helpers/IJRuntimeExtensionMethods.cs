using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Helpers
{
    public static class IJRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js,string message)
        {
            await js.InvokeVoidAsync("Console.log", "Prueba de console log");
            return await js.InvokeAsync<bool>("confirm", message);
        }
    }
}
