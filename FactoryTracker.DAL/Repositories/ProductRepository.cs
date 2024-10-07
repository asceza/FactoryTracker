using FactoryTracker.DAL.Interfaces;
using FactoryTracker.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Dictionary<int, Product> _products;

        public ProductRepository()
        {
            _products = new Dictionary<int, Product>();
        }

        private int IncrementProductId()
        {
            if (_products.Count == 0)
            {
                return 1;
            }
            else
            {
                return _products.MaxBy(k => k.Key).Key + 1;
            }
        }


        public bool AddProduct(Product product)
        {
            try
            {
                int id = IncrementProductId();
                product.ID = id;
                _products.Add(id, product);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        public Product GetProduct(string productNumber)
        {
            /* ????
             * Исключения действительно добавлены, но есть небольшой нюанс. Теперь что бы ни произошло,
             * мы смело заявляем, что виной всему является то, что нет значения в словаре. Ещё недавно
             * была проблема в том, что словарь был объявлен, но не инициализирован. Если убрать инициализацию,
             * то произойдёт исключение о том, что словарь не создан, но мы будем перехватывать и говорить, что
             * дело вовсе не в этом, а в том, что нет значения с указанным ключом.
             * В случае с базой данных таких ошибок намного больше: неправильно указан путь до базы данных и мы
             * не смогли к ней подключиться, путь указан правильно, но мы не дождались своей очереди на запрос к
             * БД, дождались, но БД ответила ошибкой и т.д.
             */


            try
            {
                KeyValuePair<int, Product> foundItem = _products.First(item => item.Value.Number == productNumber);
                if (!foundItem.Equals(new KeyValuePair<int, Product>()))
                /*
                 * Ошибка Sequence contains no matching element
                 * При попытке взять изделие по несуществующему номеру
                 */
                {
                    return foundItem.Value;
                }
                else
                {
                    throw new Exception($"В словаре _products нет значения с номером {productNumber}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка {ex.Message}");
            }
        }


        public Product[] GetAllProducts()
        {
            var allProducts = _products.Values.ToArray();
            return allProducts;
        }
    }
}
