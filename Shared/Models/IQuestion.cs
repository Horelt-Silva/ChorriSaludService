using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCreateVersion.Shared.Models
{ 

   public  class IQuestion
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int QuestionsId { get; set; }
        public int Score { get; set; }
        public int Duration { get; set; }
    }
}
