#pragma checksum "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\Pages\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecb3632452e55026c3c7362ffb18d1c2c4a5d0d5"
// <auto-generated/>
#pragma warning disable 1591
namespace ChorriSaludService.Client.Pages
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
#line 10 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\Pages\Profile.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\Pages\Profile.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/profile")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card col-6");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "model", "User");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "<div class=\"row pl-1\"><h5>Register</h5></div>\n        ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "row");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-item left");
                __builder2.AddMarkupContent(12, "<label class=\"label\">Nombres:</label>\n                    ");
                __builder2.OpenElement(13, "input");
                __builder2.AddAttribute(14, "type", "text");
                __builder2.AddAttribute(15, "class", "form-input");
                __builder2.AddAttribute(16, "placeholder", "Nombres");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\Pages\Profile.razor"
                                              User.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.FirstName = __value, User.FirstName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n                ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-item left");
                __builder2.AddMarkupContent(22, "<label class=\"label\">Apellidos:</label>\n                    ");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "type", "text");
                __builder2.AddAttribute(25, "class", "form-input");
                __builder2.AddAttribute(26, "placeholder", "Apellidos");
                __builder2.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\Pages\Profile.razor"
                                              User.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.LastName = __value, User.LastName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\n                ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-item left");
                __builder2.AddMarkupContent(32, "<label class=\"label\">Email:</label>\n                    ");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "type", "text");
                __builder2.AddAttribute(35, "class", "form-input");
                __builder2.AddAttribute(36, "placeholder", "Email");
                __builder2.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\Pages\Profile.razor"
                                              User.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.Email = __value, User.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\n            ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "col");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-item left");
                __builder2.AddMarkupContent(44, "<label class=\"label\">Tel??fono:</label>\n                    ");
                __builder2.OpenElement(45, "input");
                __builder2.AddAttribute(46, "type", "text");
                __builder2.AddAttribute(47, "class", "form-input");
                __builder2.AddAttribute(48, "placeholder", "Tel??fono");
                __builder2.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\Pages\Profile.razor"
                                              User.Phone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.Phone = __value, User.Phone));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\n                ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-item left");
                __builder2.AddMarkupContent(54, "<label class=\"label\">Tel??fono:</label>\n                    ");
                __builder2.OpenElement(55, "input");
                __builder2.AddAttribute(56, "type", "text");
                __builder2.AddAttribute(57, "class", "form-input");
                __builder2.AddAttribute(58, "placeholder", "Tel??fono");
                __builder2.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\Pages\Profile.razor"
                                              User.DNI

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.DNI = __value, User.DNI));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\n                ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-item submit-button");
                __builder2.OpenElement(64, "button");
                __builder2.AddAttribute(65, "class", "btn");
                __builder2.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\Pages\Profile.razor"
                                                  OnSave

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(67, "Guardar");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\n");
            __builder.AddMarkupContent(69, @"<style>
    .card
    {
        justify-content:left;
     
    }
    .submit-button
    {
        height:90px;
        justify-content:center;
        align-items:flex-end;
    }
    .submit-button .btn
    {
        margin-bottom:10px;
        margin-top:10px;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "E:\Hosivi\ChorriSaludService\ChorriSaludService\Client\Pages\Profile.razor"
      
    User User = new User();

    [CascadingParameter]
    public Task<AuthenticationState> authenticationState { get; set; }
    public List<Role> Lista = new List<Role>();
    protected override async Task OnInitializedAsync()
    {
        var authState = await authenticationState;
        var user = authState.User;
        Lista = await RoleManager.GetRoles();
        if (user.Identity.IsAuthenticated)
        {
            var claim = user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier);
            Console.WriteLine(claim + "aqui estoy");

            var id = Convert.ToInt64(claim?.Value);
            Console.WriteLine(id);

            var userResponse = await UserManager.GetUser(id);

            if (userResponse != null)
            {
                User = (User)userResponse;
            }
            else
            {
                Navigation.NavigateTo("/");
            }

        }
        else
        {
            Console.WriteLine("aqui estoy y no pasa nada");
        }

    }
    public void AddRole(long Id)
    {
        User.Roles_Id =Id;
        Console.WriteLine(Id);
    }
    private async Task OnSave()
    {
        await UserManager.UpdateUser(User);

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleManager RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserManager UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositories repository { get; set; }
    }
}
#pragma warning restore 1591
