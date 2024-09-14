using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker.Enums
{
    /// <summary>
    /// Роли пользователя
    /// </summary>
    public enum UserRole : byte
    {
        None,
        Brigadier,  // бригадир
        Master,     // мастер
        Director,   // директор
        Controller, // контроллер
        Logistician,// логист
    }
}
