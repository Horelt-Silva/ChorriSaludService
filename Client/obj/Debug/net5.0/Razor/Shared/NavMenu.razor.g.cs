#pragma checksum "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7caab360459ed03d15d8298ca822250b0ddf9608"
// <auto-generated/>
#pragma warning disable 1591
namespace ReCreateVersion.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\_Imports.razor"
using ReCreateVersion.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\_Imports.razor"
using ReCreateVersion.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\_Imports.razor"
using ReCreateVersion.Client.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\_Imports.razor"
using ReCreateVersion.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\_Imports.razor"
using ReCreateVersion.Client.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\_Imports.razor"
using ReCreateVersion.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\_Imports.razor"
using ReCreateVersion.Client.Shared.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\_Imports.razor"
using ReCreateVersion.Client.Shared.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\_Imports.razor"
using ReCreateVersion.Client.Shared.Components;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddAttribute(2, "b-fnz7o3nmd6");
            __builder.AddMarkupContent(3, "<div class=\"brand\" b-fnz7o3nmd6><a href=\"#\" class=\"brand_logo\" b-fnz7o3nmd6><img src=\"./statics/logoB.png\" alt b-fnz7o3nmd6></a></div>\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "nav");
            __builder.AddAttribute(6, "b-fnz7o3nmd6");
            __builder.OpenElement(7, "ul");
            __builder.AddAttribute(8, "class", "pt-4 ");
            __builder.AddAttribute(9, "b-fnz7o3nmd6");
            __builder.OpenElement(10, "li");
            __builder.AddAttribute(11, "class", "nav-item");
            __builder.AddAttribute(12, "b-fnz7o3nmd6");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(13);
            __builder.AddAttribute(14, "class", "nav-link");
            __builder.AddAttribute(15, "href", "");
            __builder.AddAttribute(16, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\Shared\NavMenu.razor"
                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, "<i class=\"bi bi-house\" b-fnz7o3nmd6></i>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenElement(20, "li");
            __builder.AddAttribute(21, "class", "nav-item");
            __builder.AddAttribute(22, "b-fnz7o3nmd6");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(23);
            __builder.AddAttribute(24, "class", "nav-link");
            __builder.AddAttribute(25, "href", "");
            __builder.AddAttribute(26, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 16 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\Shared\NavMenu.razor"
                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(28, "<i class=\"bi bi-bookmark\" b-fnz7o3nmd6></i>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n            ");
            __builder.OpenElement(30, "li");
            __builder.AddAttribute(31, "class", "nav-item");
            __builder.AddAttribute(32, "b-fnz7o3nmd6");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(33);
            __builder.AddAttribute(34, "class", "nav-link");
            __builder.AddAttribute(35, "href", "");
            __builder.AddAttribute(36, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 21 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\Shared\NavMenu.razor"
                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(38, "<i class=\"bi bi-house\" b-fnz7o3nmd6></i>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n            ");
            __builder.OpenElement(40, "li");
            __builder.AddAttribute(41, "class", "nav-item");
            __builder.AddAttribute(42, "b-fnz7o3nmd6");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(43);
            __builder.AddAttribute(44, "class", "nav-link");
            __builder.AddAttribute(45, "href", "");
            __builder.AddAttribute(46, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 26 "C:\Users\hosiv\Downloads\CapaB-sica-master\CapaB-sica-master\Client\Shared\NavMenu.razor"
                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(48, "<i class=\"bi bi-bookmark\" b-fnz7o3nmd6></i>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n");
            __builder.AddMarkupContent(50, @"<style b-fnz7o3nmd6>
    ul {
        padding-left: 0;
    }

    .sidebar_wrapper {
        width: 15%;
        position: fixed;
        justify-content: center;
        align-items: center;
        display: flex;
        height: 100vh;
    }

    .bi {
        color: white;
        font-size: 24px;
    }

    .nav-link {
        width: 100%;
        display: flex;
        justify-content: center;
    }

    .sidebar {
        height: 95vh;
        background-color: #2a00a2;
        width: 80%;
        border-radius: 24px;
        display: flex;
        flex-direction: column;
        box-shadow: 0 32px 64px 0 rgba(17, 17, 17, 0.08);
    }

    .nav {
        justify-content: center;
        display: flex;
        height: 80%;
    }

        .nav ul {
            list-style-type: none;
            height: 40%;
            width: 100%;
            display: flex;
            flex-direction: column;
            justify-content: space-between;
        }

    .nav-link {
        width: 100%;
        display: flex;
        justify-content: center;
    }

    .nav-item {
        width: 100%;
        padding-top: 20px;
        padding-bottom: 20px;
    }

        .nav-item:hover {
            background-color: #5f2eea;
        }


    /* Brand */

    .brand {
        height: 20%;
        padding-top: 20px;
    }

    .brand_logo {
        display: flex;
        justify-content: center;
    }

        .brand_logo img {
            width: 30% !important;
        }
</style>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591