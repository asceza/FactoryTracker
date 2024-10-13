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
                        bool isProductAdded = productManager.AddNewProduct(newProductNumber);

                        if (isProductAdded)
                        {
                            uiManager.ShowOneAddedProductNumber(newProductNumber);
                        }


                        var allProductsNumber = productManager.GetAllProductNumbers();
                        uiManager.ShowAllProductsNumber(allProductsNumber);
                        break;

                    
                    case MenuItem.UpdateProductStatus:
                        allProductsNumber = productManager.GetAllProductNumbers();
                        string selectedProductNumber = uiManager.GetSelectedProductNumber(allProductsNumber);

                        Product selectedProduct = productManager.GetProductByNumber(selectedProductNumber);

                        ProductStatus selectedProductStatus = uiManager.GetStatusForProduct(selectedProduct.Number);

                        bool isStatusToProductAdded = productManager.SetStatusForProduct(selectedProduct, selectedProductStatus);

                        if (isStatusToProductAdded)
                        {
                            uiManager.ShowProductWithNumberAndStatus(selectedProduct.Number, selectedProduct.ProductStatus);
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
                        //Console.WriteLine("???");
                        break;
                } 
            }
        }
    }
}
