using Set_Exercice.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_Exercice.Entities
{
    public class Course
    {
        public Course()
        {
        }

        public Course(string name, ECourseName courseName, User instructor)
        {
            Id = Guid.NewGuid();
            Name = name;
            CourseName = courseName;
            Users = new HashSet<User>();
            Instructor = instructor;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public ECourseName CourseName { get; set; }
        public HashSet<User> Users { get; set; }
        public User Instructor { get; set; }
    }
}
