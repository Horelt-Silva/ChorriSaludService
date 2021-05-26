using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReCreateVersion.Server.Context;
using ReCreateVersion.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReCreateVersion.Server.Controllers
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
