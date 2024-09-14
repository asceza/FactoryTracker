using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryTracker.Enums;

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

        public JobPosition JobPosition { get; set; }
        public UserRole Role { get; set; }

    }
}
