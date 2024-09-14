using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker.Models
{
    /// <summary>
    /// Пользователь, пребывающий в системе
    /// </summary>
    public class User
    {
        public uint ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Secondname { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public string JobPosition { get; set; }
        public UserRole? Role { get; set; }

        public User(uint id, string surname, string name, string secondname, string jobPosition, UserRole? role)
        {
            ID = id;
            Surname = surname;
            Name = name;
            Secondname = secondname;
            JobPosition = jobPosition;
            Role = role;
        }
    }
}
