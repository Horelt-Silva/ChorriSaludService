using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChorriSaludService.Shared.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Source { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DNI { get; set; }
        public long Roles_Id { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string AboutMe { get; set; }
        public long? Notifications { get; set; }
        public string Phone { get; set; }

        [Timestamp]
        public byte[] CreatedAt { get; set; }
   
   
        

        
    }
}
