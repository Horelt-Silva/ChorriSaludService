#pragma checksum "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\Shared\Authentication\LogOut.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd55c2e8a0e1939111d31f7ca43a8aa0fe301100"
// <auto-generated/>
#pragma warning disable 1591
namespace ChorriSaludService.Client.Shared.Authentication
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
    public partial class LogOut : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row logout");
            __builder.OpenElement(2, "h4");
            __builder.OpenElement(3, "b");
            __builder.AddContent(4, "Hellos, ");
            __builder.AddContent(5, 
#nullable restore
#line 5 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\Shared\Authentication\LogOut.razor"
                    context.User.Identity.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-item left");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "btn");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\Shared\Authentication\LogOut.razor"
                                      LogOutSession

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(12, "Cerrar Sesión");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n    ");
            __builder.AddMarkupContent(14, "<style>\n        .logout {\n            width: 30%;\n            display: flex;\n            justify-content: space-between;\n        }\n    </style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\Shared\Authentication\LogOut.razor"
            [Parameter]
                public AuthenticationState context { get; set; }
                public async Task LogOutSession()
                {
                    await UserManager.LogOutUser(() => Navigation.NavigateTo("/login", true));
                } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserManager UserManager { get; set; }
    }
}
#pragma warning restore 1591
