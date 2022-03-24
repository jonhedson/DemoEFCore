using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEFCore.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<TeacherStudent> TeacherStudent { get; set; }
    }
}
