using FactoryTracker.Enums;
using FactoryTracker.Models;
using FactoryTracker.Repositories;
using FactoryTracker.Services;

namespace FactoryTracker
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleInputService consoleInputService = new ConsoleInputService();
            ConsoleOutputService consoleOutputService = new ConsoleOutputService();


            User testUser1 = new User();
            testUser1.Surname = "Иванов";

            User testUser2 = new User();
            testUser2.Surname = "Петров";


            UserRepository userRepository = new UserRepository();
            userRepository.AddUser(testUser1);
            userRepository.AddUser(testUser2);

            Console.WriteLine(userRepository.GetUser(1).ToString());
            Console.WriteLine(userRepository.GetUser(8).ToString());


            Console.ReadLine();
        }
    }
}
