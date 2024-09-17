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



            User FirstTestUser = new User();
            FirstTestUser.Surname = "Иванов";





            UserRepository userRepository = new UserRepository();
            userRepository.AddUser(FirstTestUser);

            User findUser = userRepository.GetUser(1);
            Console.WriteLine(findUser.Surname);


            Console.ReadLine();
        }
    }
}
