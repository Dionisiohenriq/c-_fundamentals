using Set_Exercice.Enums;

namespace Set_Exercice.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public EUserType UserType { get; set; }

        public User(string name, EUserType userType)
        {
            Id = Guid.NewGuid();
            Name = name;
            UserType = userType;
        }
    }
}
