#pragma checksum "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\Shared\Utilities\Error.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "417a751bcd60ff234701d9ec7dea593d48759aae"
// <auto-generated/>
#pragma warning disable 1591
namespace ChorriSaludService.Client.Shared.Utilities
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\_Imports.razor"
using ChorriSaludService.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\_Imports.razor"
using ChorriSaludService.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\_Imports.razor"
using ChorriSaludService.Client.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\_Imports.razor"
using ChorriSaludService.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\_Imports.razor"
using ChorriSaludService.Client.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\_Imports.razor"
using ChorriSaludService.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\_Imports.razor"
using ChorriSaludService.Client.Shared.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\_Imports.razor"
using ChorriSaludService.Client.Shared.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\_Imports.razor"
using ChorriSaludService.Client.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\Shared\Utilities\Error.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    public partial class Error : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.ChorriSaludService.Client.Shared.Utilities.Error.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 4 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\Shared\Utilities\Error.razor"
                      this

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
                __builder2.AddContent(3, 
#nullable restore
#line 5 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\Shared\Utilities\Error.razor"
     ChildContent

#line default
#line hidden
#nullable disable
                );
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\Shared\Utilities\Error.razor"
       
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    public void ProcessError(Exception ex)
    {
        Logger.LogError("Error:ProcessError - Type: {Type} Message: {Message}", 
            ex.GetType(), ex.Message);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Error> Logger { get; set; }
    }
}
namespace __Blazor.ChorriSaludService.Client.Shared.Utilities.Error
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
