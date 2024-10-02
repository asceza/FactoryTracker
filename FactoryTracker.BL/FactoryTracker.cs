using FactoryTracker.Enums;
using FactoryTracker.UI;

namespace FactoryTracker.BL
{
    public class FactoryTracker
    {
        public void Start()
        {
            UiManager uiManager = new UiManager();
            ProductManager productManager = new ProductManager();

            while (true)
            {
                int selectMenuItem = uiManager.GetSelectedMenuItem();

                switch (selectMenuItem)
                {
                    // добавление нового изделия
                    case 1:
                        string selectedProductNumber = uiManager.RequestNewProducData();
                        bool isProductAdded = productManager.AddNewProduct(selectedProductNumber);

                        if (isProductAdded)
                        {
                            uiManager.ShowOneAddedProduct(selectedProductNumber);
                        }

                        var allProductsNumber = productManager.GetAllProductNumbers();
                        uiManager.ShowAllProducts(allProductsNumber);
                        break;
                    
                    // ввод данных о статусе изделия
                    case 2:
                        allProductsNumber = productManager.GetAllProductNumbers();
                        selectedProductNumber = uiManager.GetSelectedProductNumber(allProductsNumber);

                        // 1 получение продукта по его номеру?
                        // не удается найти тип Product
                        Product product = productManager.GetProductByNumber(selectedProductNumber);

                        // 2 получение выбранного статуса по пункту меню?
                        // архитектура не предполагает возврат типа ProductStatus из слоя UI?
                        ProductStatus product = uiManager.GetStatusForProduct(selectedProductNumber);


                        // 3 добавление статуса у продукта


                        break;
                } 
            }




        }

    }
}
