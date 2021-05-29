using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ChorriSaludService.Server.Context;
using ChorriSaludService.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ChorriSaludService.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private ApplicationDbContext context;
        private readonly ILogger<UserController> logger;

        public UserController(ILogger<UserController> logger, ApplicationDbContext context)
        {
            this.context = context;
            this.logger = logger;
        }
        //[HttpPost("loginuser")]
        //public async Task<ActionResult<User>> LoginUser(User user)
        //{
        //    //user.Password = Utility.Encrypt(user.Password);
        //    //User loggedInUser = await context.User.Where(u => u.Email == user.Email).FirstOrDefaultAsync();
        //    User loggedInUser = await context.User.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefaultAsync();
        //    if (loggedInUser != null)
        //    {
        //        //create a claim
        //        var claim = new Claim(ClaimTypes.Name, loggedInUser.Email);
        //        //create claimsIdentity
        //        var claimsIdentity = new ClaimsIdentity(new[] { claim }, "serverAuth");
        //        //create claimsPrincipal
        //        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
        //        //Sing in user
        //        await HttpContext.SignInAsync(claimsPrincipal);
        //    }
        //    //else
        //    //if (loggedInUser == null)
        //    //{
        //    //    return NotFound("Something went wrong!");
        //    //}
        //    return await Task.FromResult(loggedInUser);
        //    // return await Task.FromResult();
        //}
        [HttpPost("loginuser")]
        public async Task<ActionResult<User>> LoginUser(User user)
        {
           
            User loggedInUser = await context.User.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefaultAsync();

            if (loggedInUser != null)
            {
                //create a claim
                var claimEmail = new Claim(ClaimTypes.Email, loggedInUser.Email);
                
                var claimNameIdentifier = new Claim(ClaimTypes.NameIdentifier, loggedInUser.Id.ToString());
                var roles = new Claim(ClaimTypes.Role, loggedInUser.Roles_Id.ToString());
                //create claimsIdentity
                var claimsIdentity = new ClaimsIdentity(new[] { claimEmail, claimNameIdentifier, roles}, "serverAuth");
                //create claimsPrincipal
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                //Sign In User
                await HttpContext.SignInAsync(claimsPrincipal, GetAuthenticationProperties());
            }
            return await Task.FromResult(loggedInUser);
        }
        [HttpPost("registeruser")]
        public async Task<ActionResult<User>> Register(User user)
        {
            context.Add(user);
            await context.SaveChangesAsync();
            return user;
        }

        //[HttpGet("getcurrentuser")]
        //public async Task<ActionResult<User>> GetCurrentUser()
        //{
        //    User currentUser = new User();
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        var email = User.FindFirstValue(ClaimTypes.Email);
        //        currentUser = await context.User.Where(u => u.Email == email).FirstOrDefaultAsync();

        //        if (currentUser == null)
        //        {
        //            currentUser = new User();
        //            //currentUser.Id = context.User.Max(user => user.Id) + 1;
        //            currentUser.Id = context.User.Max(user => user.Id) + 1;
        //            currentUser.Email = User.FindFirstValue(ClaimTypes.Email);
        //            //currentUser.Source = "EXTL";
        //            context.User.Add(currentUser);
        //            await context.SaveChangesAsync();

        //        }
        //    }
        //    return await Task.FromResult(currentUser);
        //}

        //[HttpGet("getcurrentuser")]
        //public async Task<ActionResult<User>> GetCurrentUser()
        //{
        //    User currentUser = new User();

        //    if (User.Identity.IsAuthenticated)
        //    {
        //        var email = User.FindFirstValue(ClaimTypes.Name);
        //        currentUser = await context.User.Where(u => u.Email == email).FirstOrDefaultAsync();
        //        //El cambio de email a name provoca una interrupcion en la authenticacion normal
        //        if (currentUser == null)
        //        {
        //            currentUser = new User();
        //            currentUser.Id = context.User.Max(user => user.Id) + 1;
        //            currentUser.Email = User.FindFirstValue(ClaimTypes.Email);
        //            currentUser.Password = currentUser.Password;
        //            context.User.Add(currentUser);
        //            await context.SaveChangesAsync();
        //        }
        //        }

        //    return await Task.FromResult(currentUser);
        //}
        [HttpGet("getcurrentuser")]
        public async Task<ActionResult<User>> GetCurrentUser()
        {
            User currentUser = new User();

            if (User.Identity.IsAuthenticated)
            {
                currentUser.Email = User.FindFirstValue(ClaimTypes.Email);
                currentUser = await context.User.Where(u => u.Email == currentUser.Email).FirstOrDefaultAsync();

                if (currentUser == null)
                {
                    currentUser = new User();
                    currentUser.Id = context.User.Max(user => user.Id) + 1;
                    currentUser.Email = User.FindFirstValue(ClaimTypes.Email);
                    //currentUser.Password = Utility.Encrypt(currentUser.EmailAddress);
                    currentUser.Source = "EXTL";

                    context.User.Add(currentUser);

                    context.Database.OpenConnection();
                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [User] ON");
                    await context.SaveChangesAsync();
                    //try
                    //{
                        
                    //    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Categories OFF;");
                    //}
                    //finally
                    //{
                    //    context.Database.CloseConnection();
                    //}
                    
                }
            }
            return await Task.FromResult(currentUser);
        }

        [HttpGet("logoutuser")]
        public async Task<ActionResult<string>> LogOutUser()
        {
            await HttpContext.SignOutAsync();
            return "Success";
        }
        [HttpGet("getprofile/{id}")]
        public async Task<User> GetProfile(int id)
        {
            return await context.User.Where(u => u.Id == id).FirstOrDefaultAsync();
        }
        [HttpPut("updateprofile")]
        public async Task<User> UpdateProfile(User user)
        {
            User userToUpdate = await context.User.Where(u => u.Id == user.Id).FirstOrDefaultAsync();

            userToUpdate.FirstName = user.FirstName;
            userToUpdate.LastName = user.LastName;
            userToUpdate.Email = user.Email;
            userToUpdate.AboutMe = user.AboutMe;
            userToUpdate.Roles_Id = user.Roles_Id;

            await context.SaveChangesAsync();
            return await Task.FromResult(user);
        }
        [HttpGet("GoogleSignIn")]
        public async Task GoogleSignIn()
        {
            await HttpContext.ChallengeAsync(GoogleDefaults.AuthenticationScheme,
               new AuthenticationProperties { RedirectUri = "/profile" });
        }
        public AuthenticationProperties GetAuthenticationProperties()
        {
            return new AuthenticationProperties()
            {
                IsPersistent = true,
                ExpiresUtc = DateTime.Now.AddMinutes(10),
                RedirectUri = "/profile"
            };
        }
        
        [HttpGet("notauthorized")]
        public IActionResult NotAuthorized()
        {
            return Unauthorized();
        }
    }
}
