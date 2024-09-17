
using FactoryTracker.Enums;

namespace FactoryTracker.Models
{
    /// <summary>
    /// Пользователь, пребывающий в системе
    /// </summary>
    public class User
    {
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public JobPosition JobPosition { get; set; }
        public UserRole Role { get; set; }
       
    }
}
