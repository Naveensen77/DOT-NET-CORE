using Dot_Net_Core_App.Models;

namespace Dot_Net_Core_App.Data.IRepository
{
    public interface IProductRepository
    {
        void Insert(Product product);
        void Update(Product product);
        IEnumerable<Product> GetAllProduct();
        IEnumerable<Product> GetProductByID(int id);
    }
}
