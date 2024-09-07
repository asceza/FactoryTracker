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


            #region /*-----------------Тестируем сотрудника----------------*/
            Employee employee_1 = new Employee(1,
                                       "Антон Антонович Антонов",
                                       "Слесарь электромонтажник");

            #endregion


            #region /*-----------------Тестируем этап производства---------*/
            ProductStage productStage = new ProductStage(product_1,
                                                 employee_1,
                                                 CraftOperation.BlanksAssembly,
                                                 ProductStatus.ComponentsAssembly,
                                                 DateTime.Now,
                                                 4,
                                                 new Comment("Единственный комментарий для этапа производства")
                                                ); 
            #endregion



            Console.ReadLine();
        }
    }
}
