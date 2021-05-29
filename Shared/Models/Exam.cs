
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChorriSaludService.Shared.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        //public DateTime Date { get; set; } No es necesario ya que se crearon exámenes programados  
        //public List<ClassRoom> ClassRooms { get; set; }/*Aqui hay una observación*/
        public int CalificationModeId { get; set; }
        public int SubjectId { get; set; }

        public int ScoreConfigurationId { get; set; }
        public List<Question> Questions { get; set; }
        //public IFormFile Img { get; set; }
        //public bool Repeat { get; set; }
    }

}
