using FactoryTracker.UI;

namespace FactoryTracker.BL
{
    public class FactoryTracker
    {
        public void Start()
        {
            UiManager uiManager = new UiManager();
            string number = uiManager.RequestNewProducData();


            ProductManager productManager = new ProductManager();
            productManager.AddNewProduct(number);

            uiManager.ShowOneProduct(number);


            var arr = productManager.GetAllProductNumbers();
            uiManager.ShowAllProducts(arr);
        }

    }
}
