// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
