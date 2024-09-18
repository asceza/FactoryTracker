
using FactoryTracker.Enums;

namespace FactoryTracker.Models
{
    /// <summary>
    /// Пользователь (сотрудник), пребывающий в системе
    /// </summary>
    public class User
    {
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public JobPosition JobPosition { get; set; }
        public UserRole Role { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}\nSurname: {Surname}\nName: {Name}";
        }
    }
}
