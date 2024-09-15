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



            User user1 = new User();
            user1.Surname = "Иванов";





            UserRepository userRepository = new UserRepository();
            userRepository.AddUser(user1);

            User findUser = userRepository.GetUser(1);
            Console.WriteLine(findUser.Surname);


            Console.ReadLine();
        }
    }
}
