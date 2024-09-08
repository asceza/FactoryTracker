using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker
{
    /// <summary>
    /// Пользователь, пребывающий в системе
    /// </summary>
    public class User
    {
        public uint ID { get; set; }
        public string? FullName { get; set; }
        public UserRole? Role { get; set; }

        public User(uint id, string? fullName, UserRole? role)
        {
            ID = id;
            FullName = fullName;
            Role = role;
        }

        public override string ToString()
        {
            return $"-----------------User-------------------\n" +
                   $"      ID - {this.ID}\n" +
                   $"FullName - {this.FullName}\n" +
                   $"    Role - {this.Role}\n" +
                   $"----------------------------------------\n";
        }
    }
}
