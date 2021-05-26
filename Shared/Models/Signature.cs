using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ReCreateVersion.Shared.Models
{
    public class Signature
    {
        public int? Id { get; set; }
        public int Course_Id { get; set; }
        public int Teacher_Id { get; set; }
        public int Syllabus_Id { get; set; }

       }
}