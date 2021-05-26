
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCreateVersion.Shared.Models
{
    class ClassRoom
    {
        public int? Id { get; set; }
        public List<Signature> Signatues { get; set; }
        public List<Student> Students { get; set; }
        public string Grade { get; set; }

        public string Section { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }
    }
}
