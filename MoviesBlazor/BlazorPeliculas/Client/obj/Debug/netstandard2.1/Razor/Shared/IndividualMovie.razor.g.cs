#pragma checksum "C:\Users\MelanyVega\Documents\MellVga\BLAZOR-COURSE\BlazorPeliculas\BlazorPeliculas\Client\Shared\IndividualMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "892a7d810f6adb73f3660e66dbf778a364ef52b5"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPeliculas.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\MelanyVega\Documents\MellVga\BLAZOR-COURSE\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MelanyVega\Documents\MellVga\BLAZOR-COURSE\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MelanyVega\Documents\MellVga\BLAZOR-COURSE\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MelanyVega\Documents\MellVga\BLAZOR-COURSE\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MelanyVega\Documents\MellVga\BLAZOR-COURSE\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MelanyVega\Documents\MellVga\BLAZOR-COURSE\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\MelanyVega\Documents\MellVga\BLAZOR-COURSE\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\MelanyVega\Documents\MellVga\BLAZOR-COURSE\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\MelanyVega\Documents\MellVga\BLAZOR-COURSE\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\MelanyVega\Documents\MellVga\BLAZOR-COURSE\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\MelanyVega\Documents\MellVga\BLAZOR-COURSE\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\MelanyVega\Documents\MellVga\BLAZOR-COURSE\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Repositories;

#line default
#line hidden
#nullable disable
    public partial class IndividualMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "p");
            __builder.AddContent(3, "Title: ");
            __builder.OpenElement(4, "b");
            __builder.AddContent(5, 
#nullable restore
#line 2 "C:\Users\MelanyVega\Documents\MellVga\BLAZOR-COURSE\BlazorPeliculas\BlazorPeliculas\Client\Shared\IndividualMovie.razor"
                  Movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, "Release:");
            __builder.OpenElement(9, "b");
            __builder.AddContent(10, " ");
            __builder.AddContent(11, 
#nullable restore
#line 3 "C:\Users\MelanyVega\Documents\MellVga\BLAZOR-COURSE\BlazorPeliculas\BlazorPeliculas\Client\Shared\IndividualMovie.razor"
                    Movie.Releasing.ToString("dd MMM yyyy").ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 4 "C:\Users\MelanyVega\Documents\MellVga\BLAZOR-COURSE\BlazorPeliculas\BlazorPeliculas\Client\Shared\IndividualMovie.razor"
     if(ButtonShowing)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "        ");
            __builder.OpenElement(14, "div");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\MelanyVega\Documents\MellVga\BLAZOR-COURSE\BlazorPeliculas\BlazorPeliculas\Client\Shared\IndividualMovie.razor"
                                ()=>DeleteMovie.InvokeAsync(Movie)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 9 "C:\Users\MelanyVega\Documents\MellVga\BLAZOR-COURSE\BlazorPeliculas\BlazorPeliculas\Client\Shared\IndividualMovie.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "    \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\MelanyVega\Documents\MellVga\BLAZOR-COURSE\BlazorPeliculas\BlazorPeliculas\Client\Shared\IndividualMovie.razor"
       

    [Parameter] public Movie Movie{ get; set; }

    [Parameter] public bool ButtonShowing { get; set; } = false;
    [Parameter] public EventCallback<Movie> DeleteMovie { get; set; }

   

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
