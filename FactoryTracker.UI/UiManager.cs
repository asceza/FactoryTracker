using FactoryTracker.Core.Enums;

namespace FactoryTracker.UI
{
    public class UiManager
    {
        /// <summary>
        /// Выбрать пункт меню
        /// </summary>
        /// <returns></returns>
        public MenuItem GetSelectedMenuItem()
        {
            bool isParseOk = false;
            int selectMenuItem = 0;
            while (!isParseOk)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Что вы хотите сделать? Введите номер пункта...");
                Console.WriteLine("\t1 [Добавить новое изделие]\n" +
                                  "\t2 [Ввести данные о статусе изделия]\n" +
                                  "\t3 [Получить данные о статусе изделия]");
                Console.ResetColor();
                string inputString = Console.ReadLine();
                isParseOk = int.TryParse(inputString, out selectMenuItem);
            }
            return (MenuItem)selectMenuItem;
        }

        /// <summary>
        /// Запрос на добавление нового изделия
        /// </summary>
        /// <returns></returns>
        public string RequestNewProducNumber()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите номер для нового продукта...");
            Console.ResetColor();
            string number = Console.ReadLine();
            return number;
        }

        /// <summary>
        /// Показать номер одного добавленного изделия
        /// </summary>
        /// <param name="number"></param>
        public void ShowOneAddedProductNumber(string number)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Добавлено изделие № {number}");
            Console.ResetColor();
        }

        /// <summary>
        /// Показать номера всех изделий в базе
        /// </summary>
        /// <param name="productNumbers"></param>
        public void ShowAllProductsNumber(IEnumerable<string> productNumbers)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Созданы следующие изделия:");
            foreach (var number in productNumbers)
            {
                Console.WriteLine(number);
            }
            Console.ResetColor();
        }

        /// <summary>
        /// Получить номера выбранного продукта по его пункту на экране
        /// </summary>
        /// <param name="productNumbers"></param>
        /// <returns></returns>
        public string GetSelectedProductNumber(IEnumerable<string> productNumbers)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Выберите номер изделия...");
            int n = 0;
            foreach (var number in productNumbers)
            {
                Console.WriteLine(++n + " - " + number);
            }
            Console.ResetColor();

            int selectNumber = 0;
            string inputString = Console.ReadLine();
            bool isParseOk = int.TryParse(inputString, out selectNumber);
            // добавить проверку корректного ввода
            // добавить проверку выхода за диапазон значений
            return productNumbers.Skip(selectNumber - 1).First();
        }

        /// <summary>
        /// Получить статус из списка всех статусов
        /// </summary>
        /// <param name="number">Номер изделия</param>
        /// <returns></returns>
        public ProductStatus GetStatusForProduct(string number)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Выберите новый статус для изделия № {number}...");

            // приводим тип Array к типу ProductStatus[]
            var allProductStatus = (ProductStatus[])Enum.GetValues(typeof(ProductStatus));
            int s = 0;
            foreach (var status in allProductStatus)
            {
                Console.WriteLine(++s + " - " + status);
            }
            Console.ResetColor();

            int selectStatus = 0;
            string inputString = Console.ReadLine();
            bool isParseOk = int.TryParse(inputString, out selectStatus);
            // добавить проверку корректного ввода
            // добавить проверку выхода за диапазон значений

            return allProductStatus[selectStatus - 1];

        }

        /// <summary>
        /// Показать номер и статус изделия
        /// </summary>
        /// <param name="number">Номер изделия</param>
        /// <param name="productStatus">Статус</param>
        /// <exception cref="NotImplementedException"></exception>
        public void ShowProductWithNumberAndStatus(string number, ProductStatus productStatus)
        {
            Console.WriteLine($"У изделия №{number} текущий статус - {productStatus}");
        }

    }
}
