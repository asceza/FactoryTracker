using FactoryTracker.BL;
using FactoryTracker.Enums;
using FactoryTracker.DAL.Models;
using FactoryTracker.DAL.Repositories;
using FactoryTracker.UI;

namespace FactoryTracker
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Запрашиваем у UI данные по изделию
             * 2. Добавляем в ProductManager изделие
             * 3. Опционально плучение всех продуктов
             * */

            BL.FactoryTracker factoryTracker = new BL.FactoryTracker();
            factoryTracker.Start();


            Console.ReadLine();
        }
    }
}
