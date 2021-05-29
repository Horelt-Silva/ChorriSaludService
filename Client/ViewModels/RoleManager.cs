using ChorriSaludService.Client.Repositories;
using ChorriSaludService.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChorriSaludService.Client.ViewModels
{
    public class RoleManager : IRoleManager
    {
        public HttpClient HttpClient { get; set; } = new HttpClient();
       
        public Repositorie Repository { get; set; } = new Repositorie();
        public RoleManager()
        {
        }

        public async Task<List<Role>> GetRoles()
        {
            List<Role> Roles = new List<Role>();
            Repository.AddHttpClient(HttpClient);
            Uri Uri = new Uri("https://localhost:44305/role/getroles");
            var HttpResponse = await this.Repository.Get<List<Role>>(Uri.AbsoluteUri);
            if (HttpResponse.Error)
            {
                var body = HttpResponse.GetBody();
                Console.WriteLine(body);
            }
            else
            {
                Console.WriteLine("roles");
                Roles = HttpResponse.Response;
            }
            return Roles;
        }
    }
}
