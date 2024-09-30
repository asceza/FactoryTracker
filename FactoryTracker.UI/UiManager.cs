namespace FactoryTracker.UI
{
    public class UiManager
    {
        public string RequestNewProducData()
        {
            Console.WriteLine("Введите");
            string number = Console.ReadLine();
            return number;
        }

        public void ShowOneProduct(string number)
        {
            Console.WriteLine($"Добавлен {number}");
        }



        public void ShowAllProducts(string[] numbers)
        {
            Console.WriteLine("сущ. след. изд");
            //foreach
        }

    }
}
