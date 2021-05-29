using ChorriSaludService.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChorriSaludService.Client.ViewModels
{
    public interface IRoleManager
    {
        public Task<List<Role>> GetRoles();
    }
}
