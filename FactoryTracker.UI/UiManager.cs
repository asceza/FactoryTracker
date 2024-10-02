namespace FactoryTracker.UI
{
    public class UiManager
    {
        /// <summary>
        /// Выбор пункта меню
        /// </summary>
        /// <returns></returns>
        public int GetSelectedMenuItem()
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
            return selectMenuItem;
        }

        /// <summary>
        /// Запрос на добавление нового изделия
        /// </summary>
        /// <returns></returns>
        public string RequestNewProducData()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите номер для нового продукта...");
            Console.ResetColor();
            string number = Console.ReadLine();
            return number;
        }

        /// <summary>
        /// Показ одного добавленного изделия
        /// </summary>
        /// <param name="number"></param>
        public void ShowOneAddedProduct(string number)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Добавлено изделие № {number}");
            Console.ResetColor();
        }

        /// <summary>
        /// Показ всех изделий в базе
        /// </summary>
        /// <param name="productNumbers"></param>
        public void ShowAllProducts(IEnumerable<string> productNumbers)
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
        /// Получение номера выбранного продукта по его пункту на экране
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

        // архитектура не предполагает возврат типа ProductStatus?
        public int GetStatusForProduct(string number)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Вы выбрали изделие № {number}");
            return 0;
            Console.ResetColor();
        }


    }
}
