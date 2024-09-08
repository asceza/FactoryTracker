using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker.Services
{
    /// <summary>
    /// Сервис чтения данных из консоли
    /// </summary>
    public class ConsoleInputService
    {
        public string? GetStringFromUser()
        {
            return Console.ReadLine();
        }
    }
}
