using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker
{
    /// <summary>
    /// Роли пользователя
    /// </summary>
    public enum UserRole
    {
        None,
        Brigadier,  // бригадир
        Master,     // мастер
        Director,   // директор
        Controller, // контроллер
        Logistician,// логист
    }
}
