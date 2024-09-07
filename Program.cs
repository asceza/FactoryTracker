namespace FactoryTracker
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region /*-----------------Тестируем юзера---------------------*/
            User user_1 = new User(1,
                           "Иванов Иван Иванович",
                           UserRole.Brigadier
                           );
            #endregion


            #region /*-----------------Тестируем тип продукта--------------*/
            ProductType productType_1 = new ProductType(1,
                                                "Изделие_1",
                                                90
                                                );

            productType_1.AddComment("Первый комментарий");
            productType_1.AddComment("Второй комментарий");

            foreach (var c in productType_1.Comments)
            {
                Console.WriteLine(c.Text);
            }
            #endregion


            #region /*-----------------Тестируем продукт-------------------*/
            Product product_1 = new Product(1,
                                    productType_1,
                                    "2.050/24",
                                    25,
                                    DateTime.Now.AddDays(4),
                                    ProductStatus.ComponentsAssembly
                                    ); 
            #endregion





            Console.ReadLine();
        }
    }
}
