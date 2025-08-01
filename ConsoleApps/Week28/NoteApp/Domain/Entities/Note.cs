﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Domain.Entities
{
    public class Note
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
