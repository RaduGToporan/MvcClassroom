using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcClassroom.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ExamDate { get; set; }

        public List<Assignment> Assignments { get; set; }
    }
}
