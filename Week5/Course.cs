using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class Course
    {
        public int courseId { get; set; }
        public string title { get; set; }

        public Course(int courseId, string title)
        {
            this.courseId = courseId;
            this.title = title;
        }
    }
}
