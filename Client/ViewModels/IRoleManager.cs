using ReCreateVersion.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReCreateVersion.Client.ViewModels
{
    public interface IRoleManager
    {
        public Task<List<Role>> GetRoles();
    }
}
