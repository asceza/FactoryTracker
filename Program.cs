


using FactoryTracker.Enums;
using FactoryTracker.Models;
using FactoryTracker.Services;

namespace FactoryTracker
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleInputService consoleInputService = new ConsoleInputService();
            ConsoleOutputService consoleOutputService = new ConsoleOutputService();

            
            User user_1 = new User(1,
                                   "Иванов",
                                   "Иван",
                                   "Иванович",
                                   JobPosition.electrician_fitter_4th_category,
                                   UserRole.Brigadier
                                   );
            consoleOutputService.Print(user_1.Name);
            


            /*-----------------Тестируем тип продукта--------------*/
            ProductType productType_1 = new ProductType(1,
                                                "Изделие_1",
                                                90
                                                );

            productType_1.AddComment("Первый комментарий");
            productType_1.AddComment("Второй комментарий");

            foreach (var c in productType_1.Comments)
            {
                consoleOutputService.Print(c.Text);
            }


            /*-----------------Тестируем продукт-------------------*/
            Product product_1 = new Product(1,
                                    productType_1,
                                    "2.050/24",
                                    25,
                                    DateTime.Now.AddDays(4),
                                    ProductStatus.ComponentsAssembly
                                    );





            /*-----------------Тестируем этап производства---------*/
            ProductStage productStage = new ProductStage(product_1,
                                                 user_1,
                                                 CraftOperation.BlanksAssembly,
                                                 ProductStatus.ComponentsAssembly,
                                                 DateTime.Now,
                                                 4,
                                                 new Comment("Единственный комментарий для этапа производства")
                                                );


            Console.ReadLine();
        }
    }
}
