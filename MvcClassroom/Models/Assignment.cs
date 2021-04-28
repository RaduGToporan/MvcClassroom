using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcClassroom.Models
{
    public class Assignment
    {
        public Assignment()
        {
            AssignmentDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime AssignmentDate { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ClassId { get; set; }
    }
}
