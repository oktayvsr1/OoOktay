using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class Department
    {
        public int deptId { get; set; }
        public string title { get; set; }

        public List<Student> students = new List<Student>();
        public List<Course> courses = new List<Course>();

      

        public void addStudent(Student student)
        {
            this.students.Add(student);
        }

        public void addCourse(Course course)
        {
            this.courses.Add(course);
        }
    }
}
