namespace Week5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            University university = new University();
            university.newDepartment();
            university.newStudents(1);
            university.newCourse(1);


            university.getDepartment(1);
            university.getStudents(1);
        }
    }
}
