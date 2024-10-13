using FactoryTracker.BL;
using FactoryTracker.DAL.Models;
using FactoryTracker.DAL.Repositories;
using FactoryTracker.UI;

namespace FactoryTracker
{
    public class Program
    {
        static void Main(string[] args)
        {

            BL.FactoryTracker factoryTracker = new BL.FactoryTracker();
            factoryTracker.Start();


            Console.ReadLine();
        }
    }
}
