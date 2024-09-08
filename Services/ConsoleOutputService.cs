using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker.Services
{
    /// <summary>
    /// Сервис вывода на экран консоли
    /// </summary>
    public class ConsoleOutputService
    {
        /// <summary>
        /// Выводит на экран консоли текст сообщения
        /// Единственная точка связи с консольным приложением
        /// </summary>
        /// <param name="message"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Print(string message)
        {
            if (message == null) { throw new ArgumentNullException(nameof(message)); }
            Console.WriteLine(message);
        }
    }
}
