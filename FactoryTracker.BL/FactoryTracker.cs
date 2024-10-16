using FactoryTracker.UI;
using FactoryTracker.Core.Enums;
using FactoryTracker.DAL.Models;


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
                MenuItem menuItem = uiManager.GetSelectedMenuItem();

                switch (menuItem)
                {
                    case MenuItem.AddNewProduct:
                        string newProductNumber = uiManager.RequestNewProducNumber();
                        var productAddedResult = productManager.AddNewProduct(newProductNumber);

                        if (productAddedResult.IsSuccess)
                        {
                            uiManager.ShowOneAddedProductNumber(newProductNumber);
                        }
                        else
                        {
                            uiManager.ShowMessage(productAddedResult.Error, ConsoleColor.Red);
                        }

                        var allProductsNumber = productManager.GetAllProductNumbers();
                        uiManager.ShowAllProductsNumber(allProductsNumber);
                        break;

                    
                    case MenuItem.UpdateProductStatus:
                        allProductsNumber = productManager.GetAllProductNumbers();
                        string selectedProductNumber = uiManager.GetSelectedProductNumber(allProductsNumber);

                        var selectedProductResult = productManager.GetProductByNumber(selectedProductNumber);


                        ProductStatus selectedProductStatus = uiManager.GetStatusForProduct(selectedProductResult.Value.Number);

                        bool isStatusToProductAdded = productManager.SetStatusForProduct(selectedProductResult.Value, selectedProductStatus);

                        if (isStatusToProductAdded)
                        {
                            uiManager.ShowProductWithNumberAndStatus(selectedProductResult.Value.Number, selectedProductResult.Value.ProductStatus);
                        }
                        break;

                    case MenuItem.ShowProductsStatus:
                        // Product selectedProductByNumber = productManager.GetProductByNumber("111");

                        Product[] allProducts = productManager.GetAllProducts();
                        foreach (Product product in allProducts)
                        {
                            uiManager.ShowProductWithNumberAndStatus(product.Number, product.ProductStatus);
                        }
                        break;
                    default:
                        uiManager.ShowMessage("Не верный ввод, попробуйте еще раз (from bl)", ConsoleColor.Red);
                        break;
                } 
            }
        }
    }
}
