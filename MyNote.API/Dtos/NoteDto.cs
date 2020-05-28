using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyNote.API.Dtos
{
    public class NoteDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime? CreationTime { get; set; }

        public DateTime? ModificationTime { get; set; }
    }
}