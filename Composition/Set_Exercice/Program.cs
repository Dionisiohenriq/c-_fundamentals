using Set_Exercice.Entities;
using Set_Exercice.Enums;
using Set_Exercice.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Insert the Name of the Instructor: ");
        User instructor = new User(Console.ReadLine(), EUserType.Instructor);

        Course courseA = new Course("A", ECourseName.A, instructor);
        Course courseB = new Course("B", ECourseName.B, instructor);
        Course courseC = new Course("C", ECourseName.C, instructor);

        ManagerService managerService = new ManagerService();

        managerService.AddStudentsToCourse(courseA);
        managerService.AddStudentsToCourse(courseB);
        managerService.AddStudentsToCourse(courseC);

        HashSet<string> courseAResult = managerService.GetTotalStudentsByInstructor(courseA, instructor);
        HashSet<string> courseBResult = managerService.GetTotalStudentsByInstructor(courseB, instructor);
        HashSet<string> courseCResult = managerService.GetTotalStudentsByInstructor(courseC, instructor);

        var qttyStudents = new HashSet<string>(courseAResult);

        qttyStudents.UnionWith(courseBResult);
        qttyStudents.UnionWith(courseCResult);

        Console.WriteLine(qttyStudents.Count);


    }
}