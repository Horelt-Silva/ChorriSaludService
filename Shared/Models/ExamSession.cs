using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChorriSaludService.Shared.Models
{
    class ExamSession
    {
        public int Id { get; set; }
        public int Exam_Id { get; set; }
        public Status StatusTime { get; set; } = new LyfeCycle().StatusTime;
        public Status StatusCommit { get; set; } = new LyfeCycle().StatusCommit;
        public Status StatusCalification { get; set; } = new LyfeCycle().StatusCalification;

    }
}
