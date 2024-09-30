using FactoryTracker.UI;

namespace FactoryTracker.BL
{
    public class FactoryTracker
    {
        public void Start()
        {
            UiManager uiManager = new UiManager();
            int selectMenuItem = uiManager.GetSelectedMenuItem();

            switch (selectMenuItem)
            {
                case 1:
                    string number = uiManager.RequestNewProducData();
                    ProductManager productManager = new ProductManager();
                    bool isProductAdded = productManager.AddNewProduct(number);

                    if (isProductAdded)
                    {
                        uiManager.ShowOneProduct(number);
                    }

                    var allProductsNumber = productManager.GetAllProductNumbers();
                    uiManager.ShowAllProducts(allProductsNumber);
                    break;
            }




        }

    }
}
