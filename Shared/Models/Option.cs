﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCreateVersion.Shared.Models
{
    class Option
    {
            public int Id { get; set; }
            public string Content { get; set; }
            public bool Value { get; set; }
            public int DefaultQuestionId { get; set; }
        
    }
}
