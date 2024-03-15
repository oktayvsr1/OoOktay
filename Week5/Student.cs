using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class Student
    {
        public int stuId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Student(int stuId, string firstName, string lastName)
        {
            stuId = stuId;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
