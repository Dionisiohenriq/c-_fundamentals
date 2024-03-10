using Set_Exercice.Entities;
using Set_Exercice.Enums;

namespace Set_Exercice.Services
{
    public class ManagerService
    {

        public void AddStudentsToCourse(Course course)
        {
            Console.WriteLine("Insert the quantity of students in this course: ");

            if (int.TryParse(Console.ReadLine(), out int qttStudents))
            {

                for (int i = 0; i < qttStudents; i++)
                {

                    Console.WriteLine("Insert the name of the Student: ");
                    User student = new User(Console.ReadLine(), EUserType.Student);

                    course.Users.Add(student);
                }
            }
        }

        public HashSet<string> GetTotalStudentsByInstructor(Course course, User instructor)
        {
            return course.Users.Where(_ => _.UserType.Equals(EUserType.Student)).Select(_ => _.Name).Distinct().ToHashSet();
        }
    }
}