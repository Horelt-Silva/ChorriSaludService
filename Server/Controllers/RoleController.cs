using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ChorriSaludService.Server.Context;
using ChorriSaludService.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChorriSaludService.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class RoleController : Controller
    {
        private ApplicationDbContext context;

        public RoleController(ApplicationDbContext context)
        {
            this.context = context;
        }

     
        [HttpGet("getroles")]
        public async Task<List<Role>> GetRoles()
        {
            List<Role> Roles=await context.Roles.ToListAsync();
            return Roles;
        }
    }
}
