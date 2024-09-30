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

        public string RequestNewProducData()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите номер для нового продукта");
            Console.ResetColor();
            string number = Console.ReadLine();
            return number;
        }

        public void ShowOneProduct(string number)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Добавлено изделие № {number}");
            Console.ResetColor();
        }

        public void ShowAllProducts(IEnumerable<string> numbers)
        {
            Console.WriteLine("Созданы следующие изделия:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

    }
}
