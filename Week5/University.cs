using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;

namespace Week5
{
    public class University
    {
        public List<Department> departments = new List<Department>();
       
        public string getString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        public int getınt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }


        public void newDepartment()
        { 
            Department department = new Department();
            department.title = getString("Enter the title: ");
            department.deptId = getınt("Enter the department id: ");
            this.departments.Add(department);
            Console.WriteLine("new department saved");
        }
        public void newStudents(int deptId)
        {


            Student student = new Student(getınt("Student Id?"),getString("Student firstName?"),getString("Student lastName?"));
            
            foreach(Department department in departments)
            {
                if(department.deptId == deptId)
                {
                    department.addStudent(student);

                }
                else
                {
                    Console.WriteLine("No studetn with this ıd: ");
                }
            }
            Console.WriteLine("Student save for departtment with ıd: "+deptId);
        }
        public void newCourse(int deptId)
        {
           
            Course course = new Course(getınt("Course Id?"),getString("Course Title?"));
            foreach(Department department in departments)
            {
                if (department.deptId == deptId)
                {
                    department.addCourse(course);
                }
                else
                {
                    Console.WriteLine("No course with this ıd: ");
                }
            }

            //departments.Find(department => department.deptId == deptId).addCourse(course);


            
                

        }

        public void getDepartments()
        {
            foreach(Department department in departments)
            {
                Console.WriteLine(department.title+" "+department.deptId);
            }

           // departments.ForEach(department => Console.WriteLine(department.deptId+" "+department.title));

        }
        public void getDepartment(int deptId)
        {
            foreach(Department department in departments)
            {
                if(department.deptId == deptId)
                {
                    Console.WriteLine(department.deptId+" "+department.title);
                    foreach(Course course in department.courses)
                    {
                        Console.WriteLine(course.title+" "+course.courseId);
                    }
                    foreach(Student student in department.students)
                    {
                        Console.WriteLine(student.firstName+" "+student.lastName+" "+student.stuId);
                    }
                }
            }

            
        }
        public void getStudents()
        {
            foreach(Department department in departments)
            {
                foreach(Student student in department.students)
                {
                    Console.WriteLine(student.firstName+" "+student.lastName+" "+student.stuId);
                }
            }

           // departments.ForEach(department => department.students.ForEach(student=> Console.WriteLine(student.firstName+" "+student.lastName+" "+student.stuId)));
        }

        public void getStudents(int deptId)
        {
            foreach (Department department in departments)
            {
                if (department.deptId == deptId)
                {
                    foreach(Student student in department.students)
                    {
                        Console.WriteLine(student.firstName + " " + student.lastName + " " + student.stuId);
                    }
                }
            }

           // departments.FindAll(department => department.deptId == deptId).ForEach(department => department.students.ForEach(student => Console.WriteLine(student.firstName + " " + student.lastName + " " + student.stuId)));
        }
        public void getCourses()
        {
            foreach(Department department in departments)
            {
                foreach(Course course in department.courses)
                {
                    Console.WriteLine(course.title+" "+course.courseId);
                }
            }
        }

        public void getCourses(int deptId)
        {
            foreach(Department department in departments)
            {
                if(department.deptId == deptId)
                {
                    foreach(Course course in department.courses)
                    {
                        Console.WriteLine(course.title+" "+course.courseId);
                    }
                }
            }
        }

    }
}
