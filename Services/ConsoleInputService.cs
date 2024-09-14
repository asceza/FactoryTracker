using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker.Services
{
    /// <summary>
    /// Сервис чтения данных из консоли и преобразвания в объект
    /// </summary>
    public class ConsoleInputService
    {


        public string? GetStringFromUser()
        {

            // вернуть тип
            return Console.ReadLine();

        }
    }
}
